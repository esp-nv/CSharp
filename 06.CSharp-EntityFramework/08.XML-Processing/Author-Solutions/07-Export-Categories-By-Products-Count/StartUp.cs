using ProductShop.Data;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            ProductShopContext context = new ProductShopContext();

            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();
            //Console.WriteLine("DB is created!!!!!");

            //string xml1 = File.ReadAllText(Configuration.xmlFolderInsert + @"\users.xml");
            //string xml2 = File.ReadAllText(Configuration.xmlFolderInsert + @"\products.xml");
            //string xml3 = File.ReadAllText(Configuration.xmlFolderInsert + @"\categories.xml");
            //string xml4 = File.ReadAllText(Configuration.xmlFolderInsert + @"\categories-products.xml");
            string result = GetCategoriesByProductsCount(context);
            Console.WriteLine(result);
        }

        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            ImportUsersDTO[] xmlUsers = Deserialize<ImportUsersDTO[]>(inputXml, "Users");

            User[] users = xmlUsers.Select(u => new User
            {
                FirstName = u.FirstName,
                LastName = u.LastName,
                Age = u.Age
            }).ToArray();

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Length}";
        }

        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            ImportProductsDTO[] xmlProducts = Deserialize<ImportProductsDTO[]>(inputXml, "Products");

            ICollection<Product> validProducts = new List<Product>();
            foreach (var product in xmlProducts)
            {
                if (!context.Users.Any(u => u.Id == product.SellerId))
                {
                    continue;
                }
                if (!context.Users.Any(u => u.Id == product.BuyerId))
                {
                    continue;
                }

                Product curr = new Product()
                {
                    Name = product.Name,
                    Price = product.Price,
                    BuyerId = product.BuyerId,
                    SellerId = product.SellerId
                };

                validProducts.Add(curr);
            }

            context.Products.AddRange(validProducts);
            context.SaveChanges();

            return $"Successfully imported {validProducts.Count}";
        }

        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            ImportCategoriesDTO[] xmlCategories = Deserialize<ImportCategoriesDTO[]>(inputXml, "Categories");

            ICollection<Category> categories = new List<Category>();
            foreach (var category in xmlCategories)
            {
                if(category.Name == null)
                {
                    continue;
                }

                Category curr = new Category()
                {
                    Name = category.Name
                };

                categories.Add(curr);
            }

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Count}";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            ImportCategoryProductDTO[] categoryProduct = Deserialize<ImportCategoryProductDTO[]>(inputXml, "CategoryProducts");


            ICollection<CategoryProduct> collection = new List<CategoryProduct>();
            foreach (var item in categoryProduct)
            {
                if(!context.Categories.Any(c => c.Id == item.CategoryId))
                {
                    continue;
                }

                if (!context.Products.Any(p => p.Id == item.ProductId))
                {
                    continue;
                }

                CategoryProduct curr = new CategoryProduct()
                {
                    CategoryId = item.CategoryId,
                    ProductId = item.ProductId
                };

                collection.Add(curr);
            }

            context.CategoryProducts.AddRange(collection);
            context.SaveChanges();

            return $"Successfully imported {collection.Count}";
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            ExportProductsInfoDTO[] products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Take(10)
                .Select(p => new ExportProductsInfoDTO
                {
                    Name = p.Name,
                    Price = p.Price,
                    BuyerName = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                })
                .ToArray();

            return Serialize(products, "Products");
        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            ExportUserWhichSoldItems[] users = context.Users
                .Where(u => u.ProductsSold.Count > 0)
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Take(5)
                .Select(u => new ExportUserWhichSoldItems
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SoldProducts = u.ProductsSold.Select(p => new ExportSoldProductsDTO
                    {
                        Name = p.Name,
                        Price = p.Price
                    }).ToArray()
                }).ToArray();

            return Serialize(users, "Users");
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            ExportCategoriesInfoDTO[] categories = context.Categories
                .Select(c => new ExportCategoriesInfoDTO
                {
                    Name = c.Name,
                    CountProducts = c.CategoryProducts.Count,
                    AveragePrice = c.CategoryProducts.Average(p => p.Product.Price),
                    TotalRevenue = c.CategoryProducts.Sum(p => p.Product.Price)
                })
                .OrderByDescending(c => c.CountProducts)
                .ThenBy(c => c.TotalRevenue)
                .ToArray();

            return Serialize(categories, "Categories");
        }


        private static T Deserialize<T>(string inputXml, string rootName)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute(rootName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), xmlRoot);

            using StringReader reader = new StringReader(inputXml);
            T dtos = (T)xmlSerializer
                .Deserialize(reader);

            return dtos;
        }

        private static string Serialize<T>(T dto, string rootName)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute(rootName);
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), xmlRoot);

            using StringWriter writer = new StringWriter(sb);
            xmlSerializer.Serialize(writer, dto, namespaces);

            return sb.ToString().TrimEnd();
        }
    }
}