using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjectTXServer.Entity;

namespace ProjectTXServer.Models
{
    public class ProductModel
    {
        
        public string ProductId { set; get; }
        public string ProductName { set; get; }
        public string ProductDescription { set; get; }
        public string ProductCover { set; get; }
        public string ProductIntro { set; get; }
        public int ProductRate { set; get; }
        public string ProductType{ set; get; }
        public string ProductGender { set; get; }
    }
}
