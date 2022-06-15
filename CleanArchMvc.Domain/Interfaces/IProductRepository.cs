using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Category> GetById(int? id);

        Task<Product> GetProductCategory( int? id);
        Task<Category> Create(Product product);
        Task<Category> Update(Product product);
        Task<Category> Remove(Product product);
    }
}
