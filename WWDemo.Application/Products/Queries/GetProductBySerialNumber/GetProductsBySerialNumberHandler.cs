﻿using AutoMapper;
using MediatR;
using WWDemo.Application.DTOs;
using WWDemo.Application.Products.Queries.GetAllProducts;
using WWDemo.Data.Products;

namespace WWDemo.Application.Products.Queries.GetProductBySerialNumber
{
    public class GetProductBySerialNumber : IRequestHandler<GetProductBySerialNumberQuery, DTOs.ProductRepresentation>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductBySerialNumber(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<DTOs.ProductRepresentation> Handle(GetProductBySerialNumberQuery query, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProductBySerialNumber(query.SerialNumber!);

            var result = _mapper.Map<Models.Product, DTOs.ProductRepresentation>(product!);

            return result;
        }
    }
}
