using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Interfaces
{
   public interface ICategoryRepository
    {
        public Category AddCategory(Category category);
        public void DeleteCategory(int id);
        public Category UpdateCategory(Category category);
        public Category FindCategory(int id);
        public List<Category> GetAllCategories();
    }
}
