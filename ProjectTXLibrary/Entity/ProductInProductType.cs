using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTXServer.Entity
{
    public class ProductInProductType
    {
        public ProductType ProductTypeObj { get; set; }
        public string ProductTypeId { get; set; }
        public Product ProductObj { get; set; }
        public string ProductId { get; set; }
    }
}
