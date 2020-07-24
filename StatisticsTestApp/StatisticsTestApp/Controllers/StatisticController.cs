using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StatisticsTestApp.Models;
using StatisticsTestApp.Repositories;

namespace StatisticsTestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public StatisticController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
                
        [HttpGet("{stats?}")]
        public IActionResult GetStatistics(Stats stats)
        {
            if (stats?.MinimumCountInStock == null && stats?.Owner == null)
            {
                return Ok("Empty");
            }

            IEnumerable<Product> products = new List<Product>();
            try
            {
                products = _productRepository.Get(stats);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);

            }
            return Ok(products);
        }
    }
}
