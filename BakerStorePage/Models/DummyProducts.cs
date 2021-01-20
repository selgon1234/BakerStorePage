using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakerStorePage.Models
{
    public class DummyProducts : IProductCatalog
    {
        public IQueryable<Item> Items => new List<Item>
        {
            new Item {Name = "Rundstykke", Price = 5},
            new Item {Name = "Rugbrød", Price = 25},
            new Item {Name = "Baguette", Price = 30}
        }.AsQueryable<Item>();
    }
}
