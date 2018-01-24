using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTenta.Models;

namespace TestTenta.Data
{
    public class DbSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            var Cola = new Product { Name = "Coca Cola", UnitPrice = 10, ReleaseDate = DateTime.ParseExact("2005-09-01", "yyyy-MM-dd", null)};
            context.Product.Add(Cola);

            context.SaveChanges();

        }
    }
}
