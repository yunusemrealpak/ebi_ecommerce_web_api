﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Application.Wrappers
{
    public class ServiceResponse<T> : BaseResponse
    {
        public T Data { get; set; }
        public ServiceResponse(T value)
        {
            Data = value;
        }
    }
}
