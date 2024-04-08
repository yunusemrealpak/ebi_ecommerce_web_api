using ECommerceApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Domain.Entities
{
    public class ProductCategory: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
