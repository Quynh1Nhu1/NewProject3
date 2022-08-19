using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTXServer.Entity
{
    public class ProductType
    {
        public string ProductTypeId { set; get; }
        public string ProductTypeName { set; get; }
        public List<ProductInProductType> ListType { get; set; }


    }
}
