using PointOfSale;
using PointOfSale.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyager
{
    public partial class POSForm : Form
    {
        private IProductInventoryService _productInventory;
        private IPointOfSaleService _posService;
        public POSForm()
        {
            _productInventory = ProductInventoryService.Instance;
            _posService = new PointOfSaleService();
            InitializeComponent();
            AddScanButton();
        }

        private void AddScanButton()
        {
            var scanButtonColumn = new DataGridViewButtonColumn();
            scanButtonColumn.Name = "Scan";
            scanButtonColumn.Text = "Scan";
            scanButtonColumn.UseColumnTextForButtonValue = true;
            grvScanProducts.Columns.Add(scanButtonColumn);

            var removeButtonColumn = new DataGridViewButtonColumn();
            removeButtonColumn.Name = "Remove";
            removeButtonColumn.Text = "Remove";
            removeButtonColumn.UseColumnTextForButtonValue = true;
            grvScanProducts.Columns.Add(removeButtonColumn);
        }

        private void LoadUpdateProductCombo()
        {
            var allProductCodes = _productInventory.GetAllProducts().Select(s => s.ProductCode).ToList();
            cmbProductCode.DataSource = allProductCodes;
        }

        private void LoadProducts()
        {
            var products = _productInventory.GetAllProducts();

            DataTable dtProducts = new DataTable("Products");
            dtProducts.Columns.Add("ProductCode", typeof(string));
            dtProducts.Columns.Add("UnitPrice", typeof(decimal));
            dtProducts.Columns.Add("BulkPrice", typeof(string));
            dtProducts.Columns.Add("PurchaseQuantity", typeof(int));
            dtProducts.Columns.Add("Price", typeof(decimal));

            foreach (var product in products)
            {
                var scannedProductInfo = _posService.GetScannedProductInfo (product.ProductCode);
                DataRow dr = dtProducts.NewRow();
                dr["ProductCode"] = product.ProductCode;
                dr["UnitPrice"] = product.UnitPrice;
                dr["BulkPrice"] = product.Discount.Quantity != 0 ?
                                         $"{product.Discount.DiscountedPrice} for {product.Discount.Quantity}" :
                                         string.Empty;
                if (scannedProductInfo != null)
                {
                    dr["PurchaseQuantity"] = scannedProductInfo.PurchaseQuantity;
                    dr["Price"] = scannedProductInfo.TotalPrice;
                }
           
                dtProducts.Rows.Add(dr);
            }

            grvScanProducts.DataSource = dtProducts;
            lblTotalPrice.Text = $"Total Price: $" + _posService.CalculateTotal();

            if (grvScanProducts.Columns["Scan"] == null)
            {
                AddScanButton();
            }
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productCode = txtProductCode.Text;
            decimal price = _numDrUnitPrice.Value;
            if (string.IsNullOrWhiteSpace(productCode))
            {
                MessageBox.Show("Product Code is Required");
                return;
            }

            var product = _productInventory.GetProductByCode(productCode);

            if (product != null)
            {
                MessageBox.Show("Product already exists");
                return;
            }   

            var discount = new BulkOrderDiscount();
            discount.DiscountedPrice = _numDrBulkPrice.Value;
            discount.Quantity = Convert.ToInt32(_numDrBulkQuantity.Value);

            _productInventory.AddProduct(productCode, price, discount);
            MessageBox.Show("Product Added Successfully");
            ClearAll();
            LoadProducts();
            LoadUpdateProductCombo();
        }

        private void ClearAll()
        {
            txtProductCode.Text = string.Empty;
            _numDrUnitPrice.Value = 0;
            _numDrBulkPrice.Value = 0;
            _numDrBulkQuantity.Value = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ScanProduct(string productCode)
        {
            _posService.ScanProduct(productCode);
            _posService.CalculateTotal();
        }

        private void grvScanProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string productCode = grvScanProducts.Rows[e.RowIndex].Cells["ProductCode"].Value.ToString();
            if (e.ColumnIndex == grvScanProducts.Columns["Scan"].Index)
            {               
                ScanProduct(productCode);
                LoadProducts();               
            }

            if (e.ColumnIndex == grvScanProducts.Columns["Remove"].Index)
            {
                var product = _productInventory.GetProductByCode(productCode);
                _posService.GetScannedProducts().Remove(product);
                _posService.CalculateTotal();
                LoadProducts();
            }
        }

        private void cmbProductCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductCode = cmbProductCode.SelectedValue.ToString();
            var product = _productInventory.GetProductByCode(selectedProductCode);
            _numDrUpdateUnitPrice.Value = product.UnitPrice;
            if (product.Discount != null)
            {
                _numDrUpdateBulkPrice.Value = product.Discount.DiscountedPrice;
                _numDrUpdateBulkQuantity.Value = product.Discount.Quantity;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedProductCode = cmbProductCode.SelectedValue.ToString();
            var discount = new BulkOrderDiscount((int)_numDrUpdateBulkQuantity.Value, _numDrUpdateBulkPrice.Value);
            _productInventory.UpdateProduct(selectedProductCode, _numDrUpdateUnitPrice.Value, discount);
            LoadProducts();
        }
    }
}
