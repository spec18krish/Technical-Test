using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Interface
{
    public interface IProductInventoryService
    {
        void AddProduct(string productCode, decimal unitPrice, BulkOrderDiscount discount);
        Product GetProductByCode(string productCode);
        List<Product> GetAllProducts();
        void DeleteAllProducts();
        void UpdateProduct(string productCode, decimal unitPrice, BulkOrderDiscount discount);
        void UpdateProductPrice(string productCode, decimal unitPrice);
        void UpdateDiscountPrice(string productCode, BulkOrderDiscount discount);
    }
}
