using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTXServer.Entity
{
    public class Product
    {

        [DisplayName("ProductId")]
        public string ProductId { set; get; }

        [DisplayName("ProductName")]
        public string ProductName { set; get; }

        [DisplayName("ProductDescription")]
        public string ProductDescription { set; get; }
        public string ProductCover { set; get; }
        public string ProductIntro { set; get; }

        [DisplayName("ProductRate")]
        public int ProductRate { set; get; }
        public float ProductPrice { set; get; }
        public List<ProductInProductType> ListProduct { get; set; }
        public List<ProductInGender> ListProductGender { get; set; }
        public List<ProductInLocation> ListProductLocation { get; set; }
        //public List<ProductInCart> ProductInCartP { get; set; }
        //public List<ReviewInproduct> ReviewInproductP { get; set; }

        //public List<ProductInCartDevices> ProductInCartDevicesP { get; set; }

    }
}
