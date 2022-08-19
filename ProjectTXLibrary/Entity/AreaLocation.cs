using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTXServer.Entity
{
    public class AreaLocation
    {

        [DisplayName("Area")]
        public int LocateId { set; get; }
        public string LocateName { set; get; }
        public List<Product> ProductInLocation { get; set; }
        public List<ProductInLocation> ListProductLocation { get; set; }
    }
}
