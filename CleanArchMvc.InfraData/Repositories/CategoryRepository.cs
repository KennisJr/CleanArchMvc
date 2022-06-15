using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.InfraData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.InfraData.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ApplicationDbContext _categoryContext;
        public CategoryRepository(ApplicationDbContext context)
        {
           _categoryContext = context;
        }

        public async Task<Category> Create(Category category)
        {
            _categoryContext.Add(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> GetById(int? id)
        {
            
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public async Task<Category> Remove(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
