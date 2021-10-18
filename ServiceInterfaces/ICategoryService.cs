using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.ServiceInterfaces
{
    public interface ICategoryService
    {
       public Category AddCategory(CreateCategoryViewModel model);
        public Category UpdateCategory(UpdateCategoryViewModel model);
        public Category FindCategory(int id);
        public void DeleteCategory(int id);
        public List<CategoryViewModel> GetAllCategories();
     }
}
