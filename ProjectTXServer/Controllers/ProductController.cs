using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectTXServer.Data;
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
        private List<ProductModel> search(string searchKey = "")
        {
            
            var ProductQuery = from a in _context.Product
                               join b in _context.ProductInProductType on a.ProductId equals b.ProductId
                               join c in _context.ProductType on b.ProductTypeId equals c.ProductTypeId
                               join d in _context.ProductInGender on a.ProductId equals d.ProductId
                               join e in _context.Gender on d.GenderId equals e.GenderId

                               select new { a, b, c ,d,e};
            if(searchKey != "")
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
                ProductGender = x.e.GenderName
            }).ToList();
            return query;
        }
        private List<ProductTypeModel> getType()
        {
            var ProductQuery = from a in _context.ProductType
                               select new { a};
            var query = ProductQuery.Select(x => new ProductTypeModel()
            {
                ProductTypeId = x.a.ProductTypeId,
                ProductTypeName = x.a.ProductTypeName
            }).ToList();
            return query;
        }
        private List<GenderModel> getGender(string searchGender = "")
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
        private List<ProductModel> getProductByGender(string keySearch = "")
        {
            var Query = from a in _context.Product
                        join b in _context.ProductInGender on a.ProductId equals b.ProductId
                        join c in _context.Gender on b.GenderId equals c.GenderId
                        select new { a,b,c };
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
                ProductRate = x.a.ProductRate
            }).ToList();
            return query;
        }
        private List<AreaModel> getArea()
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
    }
}