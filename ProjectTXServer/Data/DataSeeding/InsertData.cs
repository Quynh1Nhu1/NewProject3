using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectTXServer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ProjectTXServer.Data.DataSeeding
{
    public static class InsertData
    {
        public static void Seed(this ModelBuilder builder)
        {
            //Id for product id
            var product1 = Guid.NewGuid().ToString();
            var product2 = Guid.NewGuid().ToString();
            var product3 = Guid.NewGuid().ToString();
            var product4 = Guid.NewGuid().ToString();
            var product5 = Guid.NewGuid().ToString();
            var product6 = Guid.NewGuid().ToString();
            var product7 = Guid.NewGuid().ToString();
            var product8 = Guid.NewGuid().ToString();
            var product9 = Guid.NewGuid().ToString();
            var product10 = Guid.NewGuid().ToString();
            var product11 = Guid.NewGuid().ToString();
            var product12 = Guid.NewGuid().ToString();
            var product13 = Guid.NewGuid().ToString();
            var product14 = Guid.NewGuid().ToString();
            var product15 = Guid.NewGuid().ToString();
            var product16 = Guid.NewGuid().ToString();
            var product17 = Guid.NewGuid().ToString();
            var product18 = Guid.NewGuid().ToString();
            var product19 = Guid.NewGuid().ToString();
            var product20 = Guid.NewGuid().ToString();
            var product21 = Guid.NewGuid().ToString();
            var product22 = Guid.NewGuid().ToString();
            var product23 = Guid.NewGuid().ToString();
            var product24 = Guid.NewGuid().ToString();
            var product25 = Guid.NewGuid().ToString();
            var product26 = Guid.NewGuid().ToString();
            var product27 = Guid.NewGuid().ToString();
            var product28 = Guid.NewGuid().ToString();
            var product29 = Guid.NewGuid().ToString();
            var product30 = Guid.NewGuid().ToString();


            //Table Products
            builder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = product1,
                    ProductName = "The Astronut",
                    ProductCover = "css/images/product_men1.PNG",
                    ProductDescription = "This is BST Product",
                    ProductIntro = "link clip",
                    ProductRate = 1
                },
                new Product()
                {
                    ProductId = product2,
                    ProductName = "BST Summer T-shirt",
                    ProductCover = "css/images/product_men2.PNG",
                    ProductDescription = "Men T-shirt The Astronut",
                    ProductIntro = "link clip",
                    ProductRate = 1
                }
                ,
                new Product()
                {
                    ProductId = product3,
                    ProductName = "King man T shirt",
                    ProductCover = "css/images/product_men3.PNG",
                    ProductDescription = "The King man T shirt make by coton",
                    ProductIntro = "link clip",
                    ProductRate = 3
                },
                new Product()
                {
                    ProductId = product4,
                    ProductName = "Anti formalism",
                    ProductCover = "css/images/product_men4.PNG",
                    ProductDescription = "The Anti formalism T-shirt for men",
                    ProductIntro = "link clip",
                    ProductRate = 3
                },
                new Product()
                {
                    ProductId = product5,
                    ProductName = "Unifas",
                    ProductCover = "css/images/product_men5.PNG",
                    ProductDescription = "This is Unifas",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product6,
                    ProductName = "T shirt for men",
                    ProductCover = "css/images/product_men6.PNG",
                    ProductDescription = "Make in china",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product7,
                    ProductName = "YourName",
                    ProductCover = "css/images/product_men7.PNG",
                    ProductDescription = "This is YourName Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product8,
                    ProductName = "T-shirt smile",
                    ProductCover = "css/images/product_men8.PNG",
                    ProductDescription = "T-shirt smile, that is the best for you",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product9,
                    ProductName = "Magic T-shirt",
                    ProductCover = "css/images/product_men9.PNG",
                    ProductDescription = "True choise for guy",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product10,
                    ProductName = "Astronaut",
                    ProductCover = "css/images/product_men10.PNG",
                    ProductDescription = "That is Astronaut",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product11,
                    ProductName = "women1",
                    ProductCover = "css/images/product_women1.PNG",
                    ProductDescription = "Headsfer T-shirt for women1 have a passion with SWAG",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product12,
                    ProductName = "women2",
                    ProductCover = "css/images/product_women2.PNG",
                    ProductDescription = "This is women2",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product13,
                    ProductName = "women3",
                    ProductCover = "css/images/product_women3.PNG",
                    ProductDescription = "This is women3",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product14,
                    ProductName = "women4",
                    ProductCover = "css/images/product_women4.PNG",
                    ProductDescription = "This is women4",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product15,
                    ProductName = "women5",
                    ProductCover = "css/images/product_women5.PNG",
                    ProductDescription = "This is women5",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product16,
                    ProductName = "women6",
                    ProductCover = "css/images/product_women6.PNG",
                    ProductDescription = "This is women6",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product17,
                    ProductName = "women7",
                    ProductCover = "css/images/product_women7.PNG",
                    ProductDescription = "This is women7",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product18,
                    ProductName = "women8",
                    ProductCover = "css/images/product_women8.PNG",
                    ProductDescription = "This is women8",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product19,
                    ProductName = "women9",
                    ProductCover = "css/images/product_women9.PNG",
                    ProductDescription = "This is women9",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product20,
                    ProductName = "women10",
                    ProductCover = "css/images/product_women10.PNG",
                    ProductDescription = "This is women10",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product21,
                    ProductName = "pantman1",
                    ProductCover = "css/images/product_pantmen1.PNG",
                    ProductDescription = "This is pantman1",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product22,
                    ProductName = "pantman2",
                    ProductCover = "css/images/product_pantmen2.PNG",
                    ProductDescription = "This is pantman2",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product23,
                    ProductName = "pantman3",
                    ProductCover = "css/images/product_pantmen3.PNG",
                    ProductDescription = "This is pantman3",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product24,
                    ProductName = "pantman4",
                    ProductCover = "css/images/product_pantmen4.PNG",
                    ProductDescription = "This is pantman4",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product25,
                    ProductName = "pantman5",
                    ProductCover = "css/images/product_pantmen5.PNG",
                    ProductDescription = "This is pantman5",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product26,
                    ProductName = "pantwoman1",
                    ProductCover = "css/images/product_pantwomen1.PNG",
                    ProductDescription = "This is pantwoman1",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product27,
                    ProductName = "pantwoman2",
                    ProductCover = "css/images/product_pantwomen2.PNG",
                    ProductDescription = "This is pantwoman2",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product28,
                    ProductName = "pantwoman3",
                    ProductCover = "css/images/product_pantwomen3.PNG",
                    ProductDescription = "This is pantwoman3",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product29,
                    ProductName = "pantwoman4",
                    ProductCover = "css/images/product_pantwomen4.PNG",
                    ProductDescription = "This is pantwoman4",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product30,
                    ProductName = "pantwoman5",
                    ProductCover = "css/images/product_pantwomen5.PNG",
                    ProductDescription = "This is pantwoman5",
                    ProductIntro = "link clip",
                    ProductRate = 5
                });



            //Table About
            //builder.Entity<About>().HasData(
            //        new About()
            //        {
            //            about_id=1,
            //            about_Url= "https://www.youtube.com/watch?v=F1vcruph8JA",
            //            about_Title = "Footwear the leading eCommerce Store around the Globe",
            //            about_Description = "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way."
            //        });

            var IdRoleStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd";
            var IdRoleAdmin = "360E601E-92F2-4F08-832B-604A21293258";



            //Table AppRole 
            builder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = IdRoleStaff,
                    Name = "Staff",
                    Description = "Staff",
                    NormalizedName = "staff"
                },
                new AppRole()
                {
                    Id = IdRoleAdmin,
                    Name = "Admin",
                    Description = "Admin",
                    NormalizedName = "admin"

                });


            var IdStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff";
            var IdAdmin = "DE544998-A3CC-4E12-ABB4-0642E57BD222";

            //Table AppUser 
            var hmac = new HMACSHA512();
            builder.Entity<AppUser>().HasData(
            new AppUser
            {
                Id = IdAdmin,
                UserName = "Admin",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHashs = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("123456Aa@")),
                PasswordSalt = hmac.Key,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserFirstName = "admin first name",
                UserLastName = "admin last name",
                UserPhoneNumber = "08658568790",
                UserDoB = new DateTime(2020, 01, 02)

            },
            new AppUser
            {
                Id = IdStaff,
                UserName = "Staff",
                NormalizedUserName = "STAFF@GMAIL.COM",
                NormalizedEmail = "STAFF@GMAIL.COM",
                Email = "staff@gmail.com",
                EmailConfirmed = true,
                PasswordHashs = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("123456Aa@")),
                PasswordSalt = hmac.Key,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserFirstName = "staff first name",
                UserLastName = "staff last name",
                UserPhoneNumber = "08658568790",
                UserDoB = new DateTime(2020, 01, 02)
            });


            //Table AppUser - role 
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = IdRoleStaff,
                UserId = IdStaff
            },
            new IdentityUserRole<string>
            {
                RoleId = IdRoleAdmin,
                UserId = IdAdmin
            });





            //var IdCart1 = "72309286-ECBB-4D20-AD95-2819D31E3400";
            //var IdCart2 = "D355458F-1DD3-4834-AA28-6DA34B6357FF";


            //Table Cart

            //builder.Entity<Cart>().HasData(
            //    new Cart()
            //    {
            //        cart_Id = IdCart1,
            //        cart_UserID = IdStaff

            //    },
            //    new Cart()
            //    {
            //        cart_Id = IdCart2,
            //        cart_UserID = IdAdmin

            //    });


            //Table Product In Cart


            // Set id for Categories
            var ifProductType1 = Guid.NewGuid().ToString();
            var ifProductType2 = Guid.NewGuid().ToString();
            //var ifProductType3 = Guid.NewGuid().ToString();
            //var ifProductType4 = Guid.NewGuid().ToString();
            //var ifProductType5 = Guid.NewGuid().ToString();


            //Table Categories
            builder.Entity<ProductType>().HasData(
                new ProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductTypeName = "Pants",

                },
                new ProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductTypeName = "Shirt",
                });
            var idGender1 = Guid.NewGuid().ToString();
            var idGender2 = Guid.NewGuid().ToString();
            //Table Gender
            builder.Entity<GenderType>().HasData(
               new GenderType()
               {
                   GenderId = idGender1,
                   GenderName = "Man",

               },
               new GenderType()
               {
                   GenderId = idGender2,
                   GenderName = "Women",
               });

            //Table Gender
            builder.Entity<AreaLocation>().HasData(
               new AreaLocation()
               {
                   LocateId = 1,
                   LocateName = "TP.HCM",

               },
               new AreaLocation()
               {
                   LocateId = 2,
                   LocateName = "Hà Nội",
               },
               new AreaLocation()
               {
                   LocateId = 3,
                   LocateName = "Đà Nẵng",
               },
               new AreaLocation()
               {
                   LocateId = 4,
                   LocateName = "Trà Vinh",
               },
               new AreaLocation()
               {
                   LocateId = 5,
                   LocateName = "Nha Trang",
               },
               new AreaLocation()
               {
                   LocateId = 6,
                   LocateName = "Vĩnh Phúc",
               },
               new AreaLocation()
               {
                   LocateId = 7,
                   LocateName = "An Giang",
               },
               new AreaLocation()
               {
                   LocateId = 8,
                   LocateName = "Cần Thơ",
               });
            //product location
            builder.Entity<ProductInLocation>().HasData(
                new ProductInLocation()
                {
                    LocateId = 1,
                    ProductId = product1
                },
                new ProductInLocation()
                {
                    LocateId = 2,
                    ProductId = product2
                },
                new ProductInLocation()
                {
                    LocateId = 3,
                     ProductId = product3
                },
                new ProductInLocation()
                {
                    LocateId = 4,
                    ProductId = product4
                },
                new ProductInLocation()
                {
                    LocateId = 5,
                    ProductId = product5
                },
                new ProductInLocation()
                {
                    LocateId = 6,
                    ProductId = product6
                },
                new ProductInLocation()
                {
                    LocateId = 7,
                    ProductId = product7
                },
                new ProductInLocation()
                {
                    LocateId = 8,
                    ProductId = product8
                },
                new ProductInLocation()
                {
                    LocateId = 1,
                    ProductId = product9
                },
                new ProductInLocation()
                {
                    LocateId = 2,
                    ProductId = product10
                },
                new ProductInLocation()
                {
                    LocateId = 3,
                    ProductId = product11
                },
                new ProductInLocation()
                {
                    LocateId = 4,
                    ProductId = product12
                },
                new ProductInLocation()
                {
                    LocateId = 5,
                    ProductId = product13
                },
                new ProductInLocation()
                {
                    LocateId = 6,
                    ProductId = product14
                },
                new ProductInLocation()
                {
                    LocateId = 7,
                    ProductId = product15
                },
                new ProductInLocation()
                {
                    LocateId = 8,
                    ProductId = product16
                },
                new ProductInLocation()
                {
                    LocateId = 1,
                    ProductId = product17
                },
                new ProductInLocation()
                {
                    LocateId = 2,
                    ProductId = product18
                },
                new ProductInLocation()
                {
                    LocateId = 3,
                    ProductId = product19
                },
                new ProductInLocation()
                {
                    LocateId = 4,
                    ProductId = product20
                },
                new ProductInLocation()
                {
                    LocateId = 5,
                    ProductId = product21
                },
                new ProductInLocation()
                {
                    LocateId = 6,
                    ProductId = product22
                },
                new ProductInLocation()
                {
                    LocateId = 7,
                    ProductId = product23
                },
                new ProductInLocation()
                {
                    LocateId = 8,
                    ProductId = product24
                },
                new ProductInLocation()
                {
                    LocateId = 1,
                    ProductId = product25
                },
                new ProductInLocation()
                {
                    LocateId = 2,
                    ProductId = product26
                },
                new ProductInLocation()
                {
                    LocateId = 3,
                    ProductId = product27
                },
                new ProductInLocation()
                {
                    LocateId = 4,
                    ProductId = product28
                },
                new ProductInLocation()
                {
                    LocateId = 5,
                    ProductId = product29
                },
                new ProductInLocation()
                {
                    LocateId = 6,
                    ProductId = product30
                });

            builder.Entity<ProductInProductType>().HasData(
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product1
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product2
                },
                 new ProductInProductType()
                 {
                     ProductTypeId = ifProductType2,
                     ProductId = product3
                 },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product4
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product5
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product6
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product7
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product8
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product9
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product10
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product11
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product12
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product13
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product14
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product15
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product16
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product17
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product18
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product19
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product20
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product21
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product22
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product23
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product24
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product25
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product26
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product27
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product28
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product29
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product30
                });

            //Table ProductInGender



            builder.Entity<ProductInGender>().HasData(
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product1
               },
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product2
               },
                new ProductInGender()
                {
                    GenderId = idGender1,
                    ProductId = product3
                },
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product4
               },
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product5
               },
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product6
               },
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product7
               },
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product8
               },
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product9
               },
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product10
               },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product11
               },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product12
               },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product13
               },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product14
               },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product15
               },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product16
               },
              new ProductInGender()
              {
                  GenderId = idGender2,
                  ProductId = product17
              },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product18
               },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product19
               },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product20
               },
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product21
               },
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product22
               },
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product23
               },
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product24
               },
               new ProductInGender()
               {
                   GenderId = idGender1,
                   ProductId = product25
               },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product26
               },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product27
               },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product28
               },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product29
               },
               new ProductInGender()
               {
                   GenderId = idGender2,
                   ProductId = product30
               });
        }
    }
}
