using ECommerceApp.Domain.Common;
using ECommerceApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Context
{
    public class ECommerceDbContext: DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var assm = Assembly.GetExecutingAssembly();
            var entityTypes = assm.GetTypes()
                .Where(type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(BaseEntity)));

            foreach (var type in entityTypes)
            {
                modelBuilder.Entity(type);
            }
        }
    }
}
