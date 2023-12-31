﻿using API.Helpers;
using AutoMapper;
using CORE.Entities;
using CORE.Interfaces;
using CORE.Specifications;
using INFRASTRUCTURE;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  
    public class ProductsController : BaseApiController
    {
        private readonly IGenericRepository<Product> _prodRepository;
        private readonly IGenericRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public ProductsController(IGenericRepository<Product> prodRepository, IGenericRepository<Category> categoryRepository,
            IMapper mapper)
        {
            _prodRepository = prodRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<Pagination<ProductToReturnDto>>> GetProducts([FromQuery] ProductSpecParams productParams)
        {
            var spec = new ProductsWithCategoriesSpecifications(productParams);
            var countSpec = new ProductWithFileterForCountSpecification(productParams);
            var totalItems = await _prodRepository.CountAsync(countSpec);
           var product = await _prodRepository.ListAsync(spec);
            var data = _mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDto>>(product);
            return Ok(new Pagination<ProductToReturnDto>(productParams.PageIndex, productParams.PageSize, totalItems, data));
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<ProductToReturnDto>> GetProduct(int id)
        {
            var spec = new ProductsWithCategoriesSpecifications(id);
            var product = await _prodRepository.GetEntityWithSpecs(spec);
            return _mapper.Map<Product, ProductToReturnDto>(product);   
        }

        [HttpGet("categories")]
        public async Task<ActionResult<IReadOnlyList<Category>>> GetCategory()
        {

            return Ok(await _categoryRepository.ListAllAsync());
        }

       
    }
}
