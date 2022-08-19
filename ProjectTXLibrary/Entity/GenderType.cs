using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTXServer.Entity
{
    public class GenderType
    {
        public string GenderId { set; get; }
        public string GenderName { set; get; }
        public List<ProductInGender> ListGender { get; set; }


    }
}
