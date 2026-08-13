namespace ProductShop
{
    using Data;
    using DTOs;
    using Models;

    using AutoMapper;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Judge don't like this approach
            //Mapper.Initialize(cfg => cfg.AddProfile(typeof(ProductShopProfile)));

            using (var context = new ProductShopContext())
            {
                //Query 1. Import Users
                //string inputJson = File.ReadAllText("../../../Datasets/users.json");
                //Console.WriteLine(ImportUsers(context, inputJson));

                //Query 2. Import Products
                //string inputJson = File.ReadAllText("../../../Datasets/products.json");
                //Console.WriteLine(ImportProducts(context, inputJson));

                //Query 3. Import Categories
                //string inputJson = File.ReadAllText("../../../Datasets/categories.json");
                //Console.WriteLine(ImportCategories(context, inputJson));

                //Query 4. Import Categories and Products
                //string inputJson = File.ReadAllText("../../../Datasets/categories-products.json");
                //Console.WriteLine(ImportCategoryProducts(context, inputJson));

                //Query 5. Export Products in Range
                //File.WriteAllText("../../../Results/products-in-range.json", GetProductsInRange(context));

                //Query 6. Export Sold Products
                //File.WriteAllText("../../../Results/users-sold-products.json", GetSoldProducts(context));

                //Query 7. Export Categories by Products Count
                File.WriteAllText("../../../Results/categories-by-products.json", GetCategoriesByProductsCount(context));

                //Query 8. Export Users and Products
                //File.WriteAllText("../../../Results/users-and-products.json", GetUsersWithProducts(context));
            }
        }

        //Query 1. Import Users
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<ProductShopProfile>());
            IMapper mapper = new Mapper(config);

            UserDTO[] userDTOs = JsonConvert.DeserializeObject<UserDTO[]>(inputJson);

            User[] users = mapper.Map<User[]>(userDTOs);

            int importedCount = 0;

            foreach (var user in users)
            {
                context.Users.Add(user);
                context.SaveChanges();
                importedCount++;
            }

            return $"Successfully imported {importedCount}";
        }

        //Query 2. Import Products
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<ProductShopProfile>());
            IMapper mapper = new Mapper(config);

            ProductDTO[] productDTOs = JsonConvert.DeserializeObject<ProductDTO[]>(inputJson);

            Product[] products = mapper.Map<Product[]>(productDTOs);

            int importedCount = 0;

            foreach (var product in products)
            {
                context.Products.Add(product);
                context.SaveChanges();
                importedCount++;
            }

            return $"Successfully imported {importedCount}";
        }

        //Query 3. Import Categories
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<ProductShopProfile>());
            IMapper mapper = new Mapper(config);

            CategoryDTO[] categoryDTOs = JsonConvert.DeserializeObject<CategoryDTO[]>(inputJson)
                .Where(c => c.Name != null)
                .ToArray();

            Category[] categories = mapper.Map<Category[]>(categoryDTOs);

            int importedCount = 0;

            foreach (var category in categories)
            {
                context.Categories.Add(category);
                context.SaveChanges();
                importedCount++;
            }

            return $"Successfully imported {importedCount}";
        }

        //Query 4. Import Categories and Products
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<ProductShopProfile>());
            IMapper mapper = new Mapper(config);

            CategoryProductDTO[] categoryProductDTOs = JsonConvert.DeserializeObject<CategoryProductDTO[]>(inputJson);

            CategoryProduct[] categoryProducts = mapper.Map<CategoryProduct[]>(categoryProductDTOs);

            context.CategoriesProducts.AddRange(categoryProducts);

            int importedCount = context.SaveChanges();

            return $"Successfully imported {importedCount}";
        }

        //Query 5. Export Products in Range
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(p => new { name = p.Name, price = p.Price, seller = $"{p.Seller.FirstName} {p.Seller.LastName}" })
                .OrderBy(p => p.price)
                .ToArray();

            string output = JsonConvert.SerializeObject(products, Formatting.Indented);

            return output;
        }

        //Query 6. Export Sold Products
        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Any(p => p.BuyerId != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    soldProducts = u.ProductsSold
                        .Where(p => p.BuyerId != null)
                        .Select(p => new
                        {
                            name = p.Name,
                            price = p.Price,
                            buyerFirstName = p.Buyer.FirstName,
                            buyerLastName = p.Buyer.LastName
                        }).ToArray()
                })
                .ToArray();

            string output = JsonConvert.SerializeObject(users, Formatting.Indented);

            return output;
        }

        //Query 7. Export Categories by Products Count
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .OrderByDescending(c => c.CategoriesProducts.Count)
                .Select(c => new
                {
                    category = c.Name,
                    productsCount = c.CategoriesProducts.Count,
                    averagePrice = $"{c.CategoriesProducts.Average(p => p.Product.Price):F2}",
                    totalRevenue = $"{c.CategoriesProducts.Sum(p => p.Product.Price):F2}"
                })
                .ToArray();

            string output = JsonConvert.SerializeObject(categories, Formatting.Indented);

            return output;
        }

        //Query 8. Export Users and Products
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Any(p => p.BuyerId != null && p.Price != null))
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    age = u.Age,
                    soldProducts = u.ProductsSold
                        .Where(p => p.BuyerId != null && p.Price != null)
                        .Select(p => new
                        {
                            name = p.Name,
                            price = p.Price
                        })
                        .ToArray()
                })
                .ToArray()
                .OrderByDescending(u => u.soldProducts.Length)
                .ToArray();

            var outputTemp = new
            {
                usersCount = users.Length,
                users = new List<object>()
            };

            foreach (var user in users)
            {
                outputTemp.users.Add(new
                {
                    user.firstName,
                    user.lastName,
                    user.age,
                    soldProducts = new
                    {
                        count = user.soldProducts.Length,
                        products = user.soldProducts
                    }
                });
            }

            string output = JsonConvert.SerializeObject(outputTemp, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            });

            return output;
        }
    }
}