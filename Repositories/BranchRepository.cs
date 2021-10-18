using AimsCarRentals.Context;
using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Repositories
{
    public class BranchRepository: IBranchRepository
    {
        public readonly AimsDbContext aimsDbContext;
        public BranchRepository(AimsDbContext aimsDbContext)
        {
            this.aimsDbContext = aimsDbContext;
        }
        public Branch AddBranch(Branch branch)
        {
            aimsDbContext.Branches.Add(branch);
            aimsDbContext.SaveChanges();
            return branch;
        }
        public Branch UpdateBranch(Branch branch)
        {
            aimsDbContext.Branches.Update(branch);
            aimsDbContext.SaveChanges();
            return branch;
        }
        public Branch Find(int id)
        {
            return aimsDbContext.Branches.Find(id);
        }
        public Branch Delete(int id)
        {
            var branch = Find(id);
            if (branch != null)
            {
                aimsDbContext.Branches.Remove(branch);
                aimsDbContext.SaveChanges();
            }
            return null;
        }
        public List<Branch> GetAll()
        {
            return aimsDbContext.Branches.ToList();
        }
    }
}
