using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.Models
{
    public class clsProduct
    {
        public string Id { get; set; }
        public string Name { get; set; }
        //Error here
        public int Price { get; set; }
    }
}
