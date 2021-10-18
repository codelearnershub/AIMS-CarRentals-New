using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.ServiceInterfaces
{
    public interface IBranchService
    {
        public Branch AddBranch(CreateBranchViewModel model);
        public Branch UpdateBranch(UpdateBranchViewModel model);
        public Branch Delete(int id);
        public Branch Find(int id);
        public List<BranchViewModel> GetAll();
    }
}
