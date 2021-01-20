using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BakerStorePage.Models;

namespace BakerStorePage.Controllers
{
    public class ProductController : Controller
    {
        private IProductCatalog repository;

        public ProductController(IProductCatalog repo)
        {
            repository = repo;
        }

        public ViewResult ProductsList() => View(repository.Items);    
    }
}
