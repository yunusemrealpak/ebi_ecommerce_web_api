using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Application.Wrappers
{
    public class BaseResponse
    {
        public BaseResponse()
        {
        }

        public BaseResponse(string message = null, bool isSuccess = true)
        {
            Message = message;
            IsSuccess = isSuccess;
        }

        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
