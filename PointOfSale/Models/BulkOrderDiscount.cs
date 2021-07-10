using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    public class BulkOrderDiscount
    {
        public BulkOrderDiscount()
        {

        }

        public BulkOrderDiscount(int quantity, decimal discountedPrice)
        {
            Quantity = quantity;
            DiscountedPrice = discountedPrice;
        }

        public int Quantity { get; set; }

        public decimal DiscountedPrice { get; set; }
    }
}
