using AimsCarRentals.Context;
using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {
        public readonly AimsDbContext _dbContext;
        public CategoryRepository(AimsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
     
        public Category AddCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return category;
        }
        public void DeleteCategory(int id)
        {
            var category = FindCategory(id);

            if (category != null)
            {
                _dbContext.Categories.Remove(category);
                _dbContext.SaveChanges();
            }
        }

        public Category UpdateCategory(Category category)
        {
            _dbContext.Categories.Update(category);
            _dbContext.SaveChanges();
            return category;
        }
        public Category FindCategory(int id)
        {
            return _dbContext.Categories.Find(id);
        }
        public List<Category> GetAllCategories()
        {
            return _dbContext.Categories.ToList();
        }
    }
}
