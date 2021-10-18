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
    public class CategoryService:ICategoryService
    {
        public readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public Category AddCategory(CreateCategoryViewModel model)
        {
            var category = new Category
            {
                Id = model.Id,
                Name = model.Name,
                CreatedAt = DateTime.Now
            };

            return _categoryRepository.AddCategory(category);
        }
     
        public Category UpdateCategory(UpdateCategoryViewModel model)
        {
            var category = new Category
            {
                Id = model.Id,
                Name = model.Name
            };
            return _categoryRepository.UpdateCategory(category);
        }
        public Category FindCategory(int id)
        {
            return _categoryRepository.FindCategory(id);
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
        }
        public List<CategoryViewModel> GetAllCategories()
        {
            var category = _categoryRepository.GetAllCategories().Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name = c.Name,
                CreatedAt = DateTime.Now

            }).ToList();
            return category;
        }
    }
}
