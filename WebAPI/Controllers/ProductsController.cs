﻿using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(template:"getall")]
        public IActionResult GetList()
        {
            var result = _productService.GetList();
            return Ok(result);
            //if(result.Success)
            //{
            //    return Ok(result);
            //}
            //    return BadRequest();
        }
    }
}
