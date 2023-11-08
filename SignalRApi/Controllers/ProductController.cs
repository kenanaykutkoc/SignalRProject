﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetList());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TInsert(new Product()
            {
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                ProductName = createProductDto.ProductName,
                ProductStatus = createProductDto.ProductStatus,
                Price = createProductDto.Price,
            });
            return Ok("Ürün Eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TgetById(id);
            _productService.TDelete(value);
            return Ok("Ürün Silindi.");

        }
        [HttpGet("GetProductWithId")]
        public IActionResult GetProductWithId(int id)
        {
            var values = _productService.TgetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                ProductID=updateProductDto.ProductID,
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                ProductName = updateProductDto.ProductName,
                ProductStatus = updateProductDto.ProductStatus,
                Price = updateProductDto.Price,
            });
            return Ok("Ürün Başarıyla Guncellendi.");
        }
    }
}