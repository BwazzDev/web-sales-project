using System;
using System.Collections.Generic;
using System.Data.Entity;
using web_sales_project.Models;

namespace web_sales_project.DAL
{
    public class ShopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var users = new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Scarlett",
                    LastName = "Stewart",
                    Username = "Scarface123",
                    Email = "scarlett.stewart@example.com",
                    Password = "christopher",
                    ProfilePicUrl = "https://randomuser.me/api/portraits/women/17.jpg",
                },
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            var sales = new List<SalesItem>
            {
                new SalesItem
                {
                    Name = "Fjallraven - Foldsack No. 1 Backpack",
                    Price = 109.95,
                    Description =
                        "Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday",
                    SalesCategory = SalesCategory.Accessory,
                    ImageUrl = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg",
                    Quantity = 5,
                    SellerId = 1,
                    ListingTimeStamp = DateTime.Parse("2021-09-01"),
                },
                new SalesItem
                {
                    Name = "Mens Casual Premium Slim Fit T-Shirts",
                    Price = 22.3,
                    Description =
                        "Slim-fitting style, contrast raglan long sleeve, three-button henley placket, light weight & soft fabric for breathable and comfortable wearing. And Solid stitched shirts with round neck made for durability and a great fit for casual fashion wear and diehard baseball fans. The Henley style round neckline includes a three-button placket.",
                    SalesCategory = SalesCategory.Shirt,
                    ImageUrl = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg",
                    Quantity = 20,
                    SellerId = 1,
                    ListingTimeStamp = DateTime.Parse("2021-09-03"),
                },
                new SalesItem
                {
                    Name = "Mens Cotton Jacket",
                    Price = 55.99,
                    Description =
                        "Great outerwear jackets for Spring/Autumn/Winter, suitable for many occasions, such as working, hiking, camping, mountain/rock climbing, cycling, traveling or other outdoors. Good gift choice for you or your family member. A warm hearted love to Father, husband or son in this thanksgiving or Christmas Day.",
                    SalesCategory = SalesCategory.Jacket,
                    ImageUrl = "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg",
                    Quantity = 3,
                    SellerId = 1,
                    ListingTimeStamp = DateTime.Parse("2021-09-03"),
                },
                new SalesItem
                {
                    Name = "Mens Casual Slim Fit",
                    Price = 15.99,
                    Description =
                        "The color could be slightly different between on the screen and in practice. / Please note that body builds vary by person, therefore, detailed size information should be reviewed below on the product description.",
                    SalesCategory = SalesCategory.Shirt,
                    ImageUrl = "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg",
                    Quantity = 10,
                    SellerId = 1,
                    ListingTimeStamp = DateTime.Parse("2021-09-01"),
                },
                new SalesItem
                {
                    Name = "Dragon Bracelet",
                    Price = 695,
                    Description =
                        "From our Legends Collection, the Naga was inspired by the mythical water dragon that protects the ocean's pearl. Wear facing inward to be bestowed with love and abundance, or outward for protection.",
                    SalesCategory = SalesCategory.Accessory,
                    ImageUrl = "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg",
                    Quantity = 1,
                    SellerId = 1,
                    ListingTimeStamp = DateTime.Parse("2021-09-04"),
                },
                new SalesItem
                {
                    Name = "Solid Gold Petite Micropave",
                    Price = 168,
                    Description =
                        "Satisfaction Guaranteed. Return or exchange any order within 30 days.Designed and sold by Hafeez Center in the United States. Satisfaction Guaranteed. Return or exchange any order within 30 days.",
                    SalesCategory = SalesCategory.Accessory,
                    ImageUrl = "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg",
                    Quantity = 2,
                    SellerId = 1,
                    ListingTimeStamp = DateTime.Parse("2021-09-03"),
                },
            };
            
            sales.ForEach(s => context.SalesItems.Add(s));
            context.SaveChanges();
        }
    }
}