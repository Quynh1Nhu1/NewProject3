using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTXServer.Entity
{
    public class ProductInLocation
    {
        public AreaLocation LocationObj { get; set; }
        public int LocateId { get; set; }
        public Product ProductObj { get; set; }
        public string ProductId { get; set; }
    }
}
