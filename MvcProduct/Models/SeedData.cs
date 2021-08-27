using System;
using System.Linq;
using MvcProduct.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MvcProduct.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcProductContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcProductContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "Country Wine",
                        Manufacturer = "Aurora",
                        RegisterDate = DateTime.Parse("2021-08-27"),
                        Type = "Bevereges",
                        Price = 12.99M
                    },

                    new Product
                    {
                        Name = "Tooth Paste",
                        Manufacturer = "Colgate",
                        RegisterDate = DateTime.Parse("2021-08-27"),
                        Type = "Hygiene",
                        Price = 0.50M
                    },

                    new Product
                    {
                        Name = "Chicken Breast",
                        Manufacturer = "Sadia",
                        RegisterDate = DateTime.Parse("2021-08-27"),
                        Type = "Meat",
                        Price = 13.50M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
