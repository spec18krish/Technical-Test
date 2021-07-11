﻿using PointOfSale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Interface
{
    public interface IPointOfSaleService
    {        
        void SetPricing(string productCode, decimal price);
        void ScanProduct(string productCode);
        decimal CalculateTotal();
        List<Product> GetScannedProducts();
        void ClearScannedProducts();
        OrderLine GetScannedProductInfo(string productCode);

    }
}
