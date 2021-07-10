﻿using PointOfSale.Interface;
using PointOfSale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    public class PointOfSaleService : IPointOfSaleService
    {        
        
        private ProductInventoryService _productInventory;
        public List<Product> ScannedProducts { get; set; }

        public PointOfSaleService()
        {
            ScannedProducts = new List<Product>();
            _productInventory = ProductInventoryService.Instance;
        }

        private decimal CalculateProductPrice(Product product, int noOfProduct)
        {
            decimal discountedPrice = 0;
            if (noOfProduct == 0)
            {
                return discountedPrice;
            }

            if (product?.Discount?.Quantity == 0)
            {
                return product.UnitPrice * noOfProduct;
            }

            //finding the number of times the discount need to be applied
            decimal noOfDiscounts = noOfProduct / product.Discount.Quantity;
            decimal actualPrice = noOfProduct * product.UnitPrice;

            //finding the number of products eligible for the discount
            decimal discountedproducts = noOfProduct - (noOfDiscounts * product.Discount.Quantity);
            //calculating the total discount price
            decimal discountPrice = ((noOfProduct - discountedproducts) * product.UnitPrice) - (noOfDiscounts * product.Discount.DiscountedPrice);
            discountedPrice = actualPrice - discountPrice;
            return discountedPrice;
        }

        public decimal CalculateTotal()
        {
            decimal totalAmount = 0;
            if (ScannedProducts.Count == 0)
            {
                return totalAmount;
            }

            ScannedProducts
              .GroupBy(g => g.ProductCode)              
              .ToList()
              .ForEach(
                   f => totalAmount += CalculateProductPrice(f.FirstOrDefault(), f.Count()
                ));          
            return totalAmount;
        }       

        public void ScanProduct(string productCode)
        {
            var productScanned = _productInventory.GetProductByCode(productCode);
            if (productScanned != null)
            {
                ScannedProducts.Add(productScanned);
            }
        }        

        public void SetPricing(string productCode, decimal price)
        {
            var product = _productInventory.GetProductByCode(productCode);
            if (product != null)
            {
                product.UnitPrice = price;
            }
        }

        public OrderLine GetScannedProductInfo(string productCode)
        {
            OrderLine orderLine = new OrderLine()
            {
                TotalPrice = 0,
                PurchaseQuantity = 0,
                ProductCode = productCode
            };
          
            var products = ScannedProducts?.Where(f => f.ProductCode == productCode).Select(s => s);
            var productDetail = _productInventory.GetProductByCode(productCode);
            if (ScannedProducts.Count() == 0 || products.Count() == 0)
            {
                return orderLine;
            }

            orderLine = new OrderLine()
            {
                PurchaseQuantity = products.Count(),
                TotalPrice = CalculateProductPrice(productDetail, products.Count())
            };

            return orderLine;
        }
    }
}
