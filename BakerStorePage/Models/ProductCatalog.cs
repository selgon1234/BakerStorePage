using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakerStorePage.Models
{
    public interface ProductCatalog
    {
        IQueryable<Item> Items { get; }
    }
}
