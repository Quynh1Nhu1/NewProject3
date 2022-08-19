using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjectTXServer.Entity;

namespace ProjectTXServer.Models
{
    public class ProductTypeModel
    {
        
        public string ProductTypeId{ set; get; }
        public string ProductTypeName { set; get; }

    }
}
