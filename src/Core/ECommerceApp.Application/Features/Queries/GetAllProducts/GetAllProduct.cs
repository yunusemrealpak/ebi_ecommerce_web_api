using AutoMapper;
using ECommerceApp.Application.Dtos;
using ECommerceApp.Application.Interfaces.Repository;
using ECommerceApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Application.Features.Queries.GetAllProducts
{
    public class GetAllProduct: IRequest<ServiceResponse<List<ProductDto>>>
    {
   
        public class GetAllProductHandler : IRequestHandler<GetAllProduct, ServiceResponse<List<ProductDto>>>
        { 
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;
            public GetAllProductHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }
            public async Task<ServiceResponse<List<ProductDto>>> Handle(GetAllProduct request, CancellationToken cancellationToken)
            {
                var products = await _productRepository.GetAllAsync();
                if (products == null)
                {
                    var response = new ServiceResponse<List<ProductDto>>([]);
                   // response.IsSuccess = false;
                    //response.Message = "Ürün bulunamadı!";
                    return response;
                    
                }
                var responseList = _mapper.Map<List<ProductDto>>(products);

                return new ServiceResponse<List<ProductDto>>(responseList);
               
            }
        }
    }
}
