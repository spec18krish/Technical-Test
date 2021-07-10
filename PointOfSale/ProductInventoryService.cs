﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    public sealed class ProductInventoryService
    {
        private List<Product> _products;
        private static ProductInventoryService _instance = new ProductInventoryService();
        private ProductInventoryService()
        {
            _products = new List<Product>();
        }

        public static ProductInventoryService Instance
        {
            get
            {
                if (_instance == null)
                {
                    return new ProductInventoryService();
                }
                return _instance;
            }           
        }

        public List<Product> Products {
            get { return _products; }
        }

        public void AddProduct(string productCode, decimal unitPrice, BulkOrderDiscount discount)
        {
            var newProduct = new Product()
            {
                ProductCode = productCode,
                UnitPrice = unitPrice,
                Discount = discount
            };

            _products.Add(newProduct);
        }

        public Product GetProductByCode(string productCode)
        {
            Product product = null;
            if (string.IsNullOrWhiteSpace(productCode))
            {
                return product;
            }

            product = _products.Find(f => f.ProductCode == productCode);
            return product;
        }


        public void UpdateProductPrice(string productCode, decimal unitPrice)
        {
            var product = GetProductByCode(productCode);
            if (product != null)
            {
                product.UnitPrice = unitPrice;
            }
        }

        public void UpdateDiscountPrice(string productCode, BulkOrderDiscount discount)
        {
            var product = GetProductByCode(productCode);
            if (product != null)
            {
                product.Discount = discount;
            }
        }


    }
}
