using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private readonly List<Category> categories;

        public CategoryInMemoryRepository()
        {
            //Add some default categories
            categories = new List<Category>()
            {
                new Category { CategoryId = 1, Name = "Category №1", Description = "Desription №1"},
                new Category { CategoryId = 2, Name = "Category №2", Description = "Desription №2"},
                new Category { CategoryId = 3, Name = "Category №3", Description = "Desription №3"},
                new Category { CategoryId = 4, Name = "Category №4", Description = "Desription №4"},
                new Category { CategoryId = 5, Name = "Category №5", Description = "Desription №5"},
                new Category { CategoryId = 6, Name = "Category №6", Description = "Desription №6"},
            };
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            var maxId = categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;
            categories.Add(category);
        }

        public void DeleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }
    }
}
