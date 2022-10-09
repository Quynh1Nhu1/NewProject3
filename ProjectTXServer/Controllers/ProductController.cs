using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectTXServer.Data;
using ProjectTXServer.Entity;
using ProjectTXServer.Models;

namespace ProjectTXServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{searchKey}")]
        public List<ProductModel> Search(string searchKey)
        {
            return search(searchKey);
        }
        [HttpGet]
        public List<ProductModel> GetAll()
        {
            return search();
        }
        [HttpGet]
        [Route("GetProductType")]
        public List<ProductTypeModel> ProductType()
        {
            return getType();
        }
        [HttpGet]
        [Route("GetProductGender")]
        public List<GenderModel> ProductGender()
        {
            return getGender();
        }
        [HttpGet]
        [Route("GetProductArea")]
        public List<AreaModel> ProductArea()
        {
            return getArea();
        }
        [HttpGet]
        [Route("GetProductByGender/{searchKey}")]
        public List<ProductModel> ProductByGender(string searchKey)
        {
            return getProductByGender(searchKey);
        }
        [HttpGet]
        [Route("GetProductByType/{searchKey}")]
        public List<ProductModel> ProductByType(string searchKey)
        {
            return getProductByType(searchKey);
        }
        [HttpGet]
        [Route("GetProductByLocate/{searchKey}")]
        public List<ProductModel> ProductByLocate(int searchKey)
        {
            return getProductByLocate(searchKey);
        }
        [HttpGet]
        [Route("GetProductByPrice/{searchKey}")]
        public List<ProductModel> ProductByPrice(int searchKey)
        {
            return getProductByPrice(searchKey);
        }
        [HttpPost]
        [Route("ResgisterProduct")]
        public async Task ResgisterProduct(ProductModel product)
        {
            await resgisterProduct(product);
        }
        [HttpPut]
        [Route("UpdateProduct")]
        public async Task UpdateProduct(ProductModel product)
        {
            await updateProduct(product);
        }
        [HttpDelete]
        [Route("DeleteProduct")]
        public async Task DeleteProduct(string productId)
        {
            await deleteProduct(productId);
        }
        private async Task deleteProduct(string productId)
        {
            try
            {
                var query = _context.Product.FirstOrDefault(x => x.ProductId == productId);

                _context.Product.Remove(query);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task resgisterProduct(ProductModel product)
        {
            try
            {

                var productId = Guid.NewGuid().ToString();
                _context.Product.Add(new Product()
                {
                    ProductId = productId,
                    ProductName = product.ProductName,
                    ProductDescription = product.ProductDescription,
                    ProductIntro = product.ProductIntro,
                    ProductCover = product.ProductCover,
                    ProductRate = product.ProductRate,
                    ProductPrice = product.ProductPrice
                });
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async Task updateProduct(ProductModel product)
        {
            try
            {
                var query = _context.Product.FirstOrDefault(x => x.ProductId == product.ProductId);
                query.ProductName = product.ProductName;
                query.ProductDescription = product.ProductDescription;
                query.ProductIntro = product.ProductIntro;
                query.ProductCover = product.ProductCover;
                query.ProductRate = product.ProductRate;
                query.ProductPrice = product.ProductPrice;

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private List<ProductModel> search(string searchKey = "")
        {
            try
            {
                var ProductQuery = from a in _context.Product
                                   join b in _context.ProductInProductType on a.ProductId equals b.ProductId
                                   join c in _context.ProductType on b.ProductTypeId equals c.ProductTypeId
                                   join d in _context.ProductInGender on a.ProductId equals d.ProductId
                                   join e in _context.Gender on d.GenderId equals e.GenderId
                                   join f in _context.ProductInLocation on a.ProductId equals f.ProductId
                                   join g in _context.AreaLocation on f.LocateId equals g.LocateId
                                   select new { a, b, c, d, e, g };
                if (searchKey != "")
                {
                    ProductQuery = ProductQuery
                        .Where(text => text.a.ProductName.Contains(searchKey) ||
                        text.c.ProductTypeName.Contains(searchKey) ||
                        text.e.GenderName.Contains(searchKey));
                }

                var query = ProductQuery.Select(x => new ProductModel()
                {
                    ProductId = x.a.ProductId,
                    ProductName = x.a.ProductName,
                    ProductDescription = x.a.ProductDescription,
                    ProductIntro = x.a.ProductIntro,
                    ProductCover = x.a.ProductCover,
                    ProductRate = x.a.ProductRate,
                    ProductType = x.c.ProductTypeName,
                    ProductArea = x.g.LocateName,
                    ProductAreaId = x.g.LocateId,
                    ProductPrice = x.a.ProductPrice

                }).ToList();
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<ProductTypeModel> getType()
        {
            try
            {
                var ProductQuery = from a in _context.ProductType
                                   select new { a };
                var query = ProductQuery.Select(x => new ProductTypeModel()
                {
                    ProductTypeId = x.a.ProductTypeId,
                    ProductTypeName = x.a.ProductTypeName
                }).ToList();
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<GenderModel> getGender(string searchGender = "")
        {
            try
            {
                var Query = from a in _context.Gender
                            select new { a };

                var query = Query.Select(x => new GenderModel()
                {
                    GenderId = x.a.GenderId,
                    GenderName = x.a.GenderName
                }).ToList();
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<ProductModel> getProductByGender(string keySearch = "")
        {
            try
            {
                var Query = from a in _context.Product
                            join b in _context.ProductInGender on a.ProductId equals b.ProductId
                            join c in _context.Gender on b.GenderId equals c.GenderId
                            join d in _context.ProductInProductType on a.ProductId equals d.ProductId
                            join e in _context.ProductType on d.ProductTypeId equals e.ProductTypeId
                            join f in _context.ProductInLocation on a.ProductId equals f.ProductId
                            join g in _context.AreaLocation on f.LocateId equals g.LocateId
                            select new { a, b, c, d, e, f, g };
                if (keySearch != "")
                {
                    Query = Query
                         .Where(text => text.c.GenderName.Contains(keySearch));
                }
                var query = Query.Select(x => new ProductModel()
                {
                    ProductId = x.a.ProductId,
                    ProductName = x.a.ProductName,
                    ProductDescription = x.a.ProductDescription,
                    ProductIntro = x.a.ProductIntro,
                    ProductCover = x.a.ProductCover,
                    ProductRate = x.a.ProductRate,
                    ProductType = x.e.ProductTypeName,
                    ProductGender = x.c.GenderName,
                    ProductArea = x.g.LocateName,
                    ProductAreaId = x.g.LocateId,
                    ProductPrice = x.a.ProductPrice
                }).ToList();
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<ProductModel> getProductByType(string keySearch = "")
        {
            try
            {
                var Query = from a in _context.Product
                            join b in _context.ProductInGender on a.ProductId equals b.ProductId
                            join c in _context.Gender on b.GenderId equals c.GenderId
                            join d in _context.ProductInProductType on a.ProductId equals d.ProductId
                            join e in _context.ProductType on d.ProductTypeId equals e.ProductTypeId
                            join f in _context.ProductInLocation on a.ProductId equals f.ProductId
                            join g in _context.AreaLocation on f.LocateId equals g.LocateId
                            select new { a, b, c, d, e, f, g };
                if (keySearch != "")
                {
                    Query = Query
                         .Where(text => text.e.ProductTypeName.Contains(keySearch));
                }
                var query = Query.Select(x => new ProductModel()
                {
                    ProductId = x.a.ProductId,
                    ProductName = x.a.ProductName,
                    ProductDescription = x.a.ProductDescription,
                    ProductIntro = x.a.ProductIntro,
                    ProductCover = x.a.ProductCover,
                    ProductRate = x.a.ProductRate,
                    ProductType = x.e.ProductTypeName,
                    ProductArea = x.g.LocateName,
                    ProductAreaId = x.g.LocateId,
                    ProductPrice = x.a.ProductPrice
                }).ToList();
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<ProductModel> getProductByLocate(int keySearch = 0)
        {
            try
            {
                var Query = from a in _context.Product
                            join b in _context.ProductInGender on a.ProductId equals b.ProductId
                            join c in _context.Gender on b.GenderId equals c.GenderId
                            join d in _context.ProductInProductType on a.ProductId equals d.ProductId
                            join e in _context.ProductType on d.ProductTypeId equals e.ProductTypeId
                            join f in _context.ProductInLocation on a.ProductId equals f.ProductId
                            join g in _context.AreaLocation on f.LocateId equals g.LocateId
                            select new { a, b, c, d, e, f, g };
                if (keySearch != 0)
                {
                    Query = Query
                         .Where(text => text.g.LocateId == keySearch);
                }
                var query = Query.Select(x => new ProductModel()
                {
                    ProductId = x.a.ProductId,
                    ProductName = x.a.ProductName,
                    ProductDescription = x.a.ProductDescription,
                    ProductIntro = x.a.ProductIntro,
                    ProductCover = x.a.ProductCover,
                    ProductRate = x.a.ProductRate,
                    ProductType = x.e.ProductTypeName,
                    ProductArea = x.g.LocateName,
                    ProductAreaId = x.g.LocateId,
                    ProductPrice = x.a.ProductPrice
                }).ToList();
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<ProductModel> getProductByPrice(int keySearch = 0)
        {
            try
            {
                var Query = from a in _context.Product
                            join b in _context.ProductInGender on a.ProductId equals b.ProductId
                            join c in _context.Gender on b.GenderId equals c.GenderId
                            join d in _context.ProductInProductType on a.ProductId equals d.ProductId
                            join e in _context.ProductType on d.ProductTypeId equals e.ProductTypeId
                            join f in _context.ProductInLocation on a.ProductId equals f.ProductId
                            join g in _context.AreaLocation on f.LocateId equals g.LocateId
                            select new { a, b, c, d, e, f, g };
                if (keySearch != 0)
                {
                    if (keySearch == 1)
                    {
                        Query = Query
                         .Where(text => text.a.ProductPrice <= 500000 & text.a.ProductPrice >= 0);
                    }
                    else if (keySearch == 2)
                    {
                        Query = Query
                        .Where(text => text.a.ProductPrice <= 2000000 & text.a.ProductPrice > 500000);
                    }
                    else if (keySearch == 3)
                    {
                        Query = Query
                        .Where(text => text.a.ProductPrice <= 5000000 & text.a.ProductPrice > 2000000);
                    }
                    else if (keySearch == 4)
                    {
                        Query = Query
                        .Where(text => text.a.ProductPrice > 5000000);
                    }

                }
                var query = Query.Select(x => new ProductModel()
                {
                    ProductId = x.a.ProductId,
                    ProductName = x.a.ProductName,
                    ProductDescription = x.a.ProductDescription,
                    ProductIntro = x.a.ProductIntro,
                    ProductCover = x.a.ProductCover,
                    ProductRate = x.a.ProductRate,
                    ProductType = x.e.ProductTypeName,
                    ProductArea = x.g.LocateName,
                    ProductAreaId = x.g.LocateId,
                    ProductPrice = x.a.ProductPrice
                }).ToList();
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<AreaModel> getArea()
        {
            try
            {
                var ProductQuery = from a in _context.AreaLocation
                                   select new { a };
                var query = ProductQuery.Select(x => new AreaModel()
                {
                    LocateId = x.a.LocateId,
                    LocateName = x.a.LocateName
                }).ToList();
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}