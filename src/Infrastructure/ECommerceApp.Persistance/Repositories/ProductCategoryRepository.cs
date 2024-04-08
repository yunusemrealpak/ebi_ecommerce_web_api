using ECommerceApp.Application.Interfaces.Repository;
using ECommerceApp.Domain.Entities;
using ECommerceApp.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Persistance.Repositories
{
    public class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
}
