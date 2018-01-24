using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTenta.Models;

namespace TestTenta.Data
{
    public class DbSeed
    {
        public static void Seed(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {

            var Bread = new Product { Name = "Loaf", UnitPrice = 7, ReleaseDate = DateTime.ParseExact("2015-10-01", "yyyy-MM-dd", null) };
            context.Product.Add(Bread);
            var Milk = new Product { Name = "Milk", UnitPrice = 2, ReleaseDate = DateTime.ParseExact("2018-01-01", "yyyy-MM-dd", null) };
            context.Product.Add(Milk);
            var Cola = new Product { Name = "Coca Cola", UnitPrice = 10, ReleaseDate = DateTime.ParseExact("2005-09-01", "yyyy-MM-dd", null) };
            context.Product.Add(Cola);

            context.SaveChanges();

            var user = new ApplicationUser { UserName = "admin@test.com"};
            var result = userManager.CreateAsync(user, "pA$$w0rd").Result;
            var admin = new IdentityRole { Name = "admin" };
            var role = roleManager.CreateAsync(admin).Result;
            userManager.AddToRoleAsync(user, "admin");

            user  = new ApplicationUser { UserName = "student@test.com"};
            result = userManager.CreateAsync(user, "pA$$w0rd").Result;
        }

        
    }
}
