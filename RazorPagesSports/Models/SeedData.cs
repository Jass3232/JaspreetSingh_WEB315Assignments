using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Linq;

namespace RazorPagesSports.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesSportsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesSportsContext>>()))
            {
                // Look for any Game.
                if (context.Sports.Any())
                {
                    return;   // DB has been seeded
                }

                context.Sports.AddRange(
                  
                    new Sports
                    {
                        Name_of_Game = "Rio Bravo",
                        Uniform_Color = "Western",
                        Number_of_Player = 67,
                        First_Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}