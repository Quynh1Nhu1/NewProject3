using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTXServer.Entity
{
    public class ProductInGender
    {
        public GenderType GenderObj { get; set; }
        public string GenderId { get; set; }
        public Product ProductObj { get; set; }
        public string ProductId { get; set; }
    }
}
