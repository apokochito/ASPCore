using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCore.Models;

namespace ASPCore.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("demo1")]
        public IActionResult Demo1()
        {
            return new JsonResult("Hello");
        }

        [Route("demo2/{fullName}")]
        public IActionResult Demo2(String fullName)
        {
            return new JsonResult("Hello " + fullName);
        }

        [Route("demo3")]
        public IActionResult Demo3()
        {
            var product = new clsProduct()
            {
                Id = "p01",
                Name = "Chair",
                Price = 500
            };
            return new JsonResult(product);
        }

        [Route("demo4")]
        public IActionResult Demo4()
        {
            var products = new List<clsProduct>()
            {
                new clsProduct()
                {
                    Id = "p01",
                    Name = "Chair",
                    Price = 500
                },
                new clsProduct()
                {
                    Id = "p02",
                    Name = "Table",
                    Price = 1000
                },
                new clsProduct()
                {
                    Id = "p03",
                    Name = "Curtain",
                    Price = 200
                }
             };  
            return new JsonResult(products);
        }
    }
}