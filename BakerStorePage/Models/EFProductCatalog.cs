using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakerStorePage.Models
{
    public class EFProductCatalog : IProductCatalog
    {
        private ApplicationDbContext context;
        public EFProductCatalog(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Item> Items => context.Items;
    }
}
