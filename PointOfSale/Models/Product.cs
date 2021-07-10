using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    public  class Product
    {
        public string ProductCode { get; set; }
        public decimal UnitPrice { get; set; }
        public BulkOrderDiscount Discount { get; set; }
    }
}
