﻿using ECommerceApp.Application.Dtos;
using ECommerceApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Application.Interfaces.Repository
{
    public interface IProductCategoryRepository: IGenericRepository<ProductCategory>
    {
    }
}
