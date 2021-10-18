using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Interfaces
{
    public interface IBranchRepository
    {
        public Branch AddBranch(Branch branch);
        public Branch UpdateBranch(Branch branch);
        public Branch Find(int id);
        public Branch Delete(int id);
        public List<Branch> GetAll();
    }
}
