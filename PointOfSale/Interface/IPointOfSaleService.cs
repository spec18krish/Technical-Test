using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Interface
{
    interface IPointOfSaleService
    {        
        void SetPricing(string productCode, decimal price);
        void ScanProduct(string productCode);
        decimal CalculateTotal();
    }
}
