using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Services
{
    public class BranchService :IBranchService
    {
        public readonly IBranchRepository branchRepository;
        public BranchService(IBranchRepository branchRepository)
        {
            this.branchRepository = branchRepository;
        }
        public Branch AddBranch(CreateBranchViewModel model)
        {
            var branch = new Branch
            {
                Name = model.Name,
               Address = model.Address,
               CreatedAt = DateTime.Now
            };
            return branchRepository.AddBranch(branch);

        }
        public Branch UpdateBranch(UpdateBranchViewModel model)
        {
            var branch = new Branch
            {
                Id = model.Id,
                Name = model.Name,
                Address = model.Address
            };
            return branchRepository.UpdateBranch(branch);
        }
        public Branch Delete(int id)
        {
            return branchRepository.Delete(id);
        }
        public Branch Find(int id)
        {
            return branchRepository.Find(id);
        }
        public List<BranchViewModel> GetAll()
        {
            var branch = branchRepository.GetAll().Select(c => new BranchViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Address = c.Address,
                CreatedAt = c.CreatedAt
            }).ToList();
            return branch;

        }
    }
}

