using eShop_V1.Data.Enums;
using eShop_V1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace eShop_V1.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Markets 
                if (!context.Markets.Any())
                {
                    context.Markets.AddRange(new List<Market>()
                    {
                        new Market()
                        {
                            Name= "Laptop Market",
                            Logo= "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description= "This is the description of the Laptop Market"
                        },
                        new Market()
                        {
                            Name= "Computer Market",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description= "This is the description of the Computer Market"
                        },
                         new Market()
                        {
                            Name= "SmartPhone Market",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description= "This is the description of the SmartPhone Market"
                        },
                          new Market()
                        {
                            Name= "SmartTV Market",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description= "This is the description of the SmartTV Market"
                        },
                          new Market()
                        {
                            Name= "Other Market",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description= "This is the description of the Other Market"
                        },
                    });
                    context.SaveChanges();

                }
                //Products
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name= "Laptop",
                            Description= "This is the description of the Laptop",
                            Price= 30.50,
                            ImageURL=" https://th.bing.com/th/id/OIP.gwwygDi0BupR9vbciGuMwQHaF_?w=244&h=197&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                            MarketId= 3,
                            ProductCategory= ProductCategory.Laptop
                        },

                        new Product()
                        {
                            Name= "Computer",
                            Description= "This is the description of the Computer",
                            Price= 31.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            MarketId= 1,
                            ProductCategory= ProductCategory.Computer
                        },
                        new Product()
                        {
                            Name= "Smart Phone",
                            Description= "This is the description of the Smart phone",
                            Price= 32.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            MarketId= 4,
                            ProductCategory= ProductCategory.SmartPhone
                        },
                         new Product()
                        {
                            Name= "Smart TV",
                            Description= "This is the description of the Smart TV",
                            Price= 33.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            MarketId= 1,
                            ProductCategory= ProductCategory.SmartTV
                        },


                    });
                    context.SaveChanges();    

                }
            }
        }
    }
}
