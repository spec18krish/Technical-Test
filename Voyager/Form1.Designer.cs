namespace Voyager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPointOfSale = new System.Windows.Forms.TabControl();
            this.tabAddProduct = new System.Windows.Forms.TabPage();
            this.tabScanProduct = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblBulkQuantity = new System.Windows.Forms.Label();
            this.lblBulkPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this._numDrBulkPrice = new System.Windows.Forms.NumericUpDown();
            this._numDrBulkQuantity = new System.Windows.Forms.NumericUpDown();
            this._numDrUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.grvScanProducts = new System.Windows.Forms.DataGridView();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tabPointOfSale.SuspendLayout();
            this.tabAddProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numDrBulkPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrBulkQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvScanProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPointOfSale
            // 
            this.tabPointOfSale.Controls.Add(this.tabAddProduct);
            this.tabPointOfSale.Controls.Add(this.tabScanProduct);
            this.tabPointOfSale.Location = new System.Drawing.Point(12, 12);
            this.tabPointOfSale.Name = "tabPointOfSale";
            this.tabPointOfSale.SelectedIndex = 0;
            this.tabPointOfSale.Size = new System.Drawing.Size(1169, 635);
            this.tabPointOfSale.TabIndex = 0;
            // 
            // tabAddProduct
            // 
            this.tabAddProduct.Controls.Add(this.panel1);
            this.tabAddProduct.Location = new System.Drawing.Point(4, 22);
            this.tabAddProduct.Name = "tabAddProduct";
            this.tabAddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddProduct.Size = new System.Drawing.Size(1161, 609);
            this.tabAddProduct.TabIndex = 0;
            this.tabAddProduct.Text = "Add Product";
            this.tabAddProduct.UseVisualStyleBackColor = true;
            // 
            // tabScanProduct
            // 
            this.tabScanProduct.Location = new System.Drawing.Point(4, 22);
            this.tabScanProduct.Name = "tabScanProduct";
            this.tabScanProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabScanProduct.Size = new System.Drawing.Size(821, 500);
            this.tabScanProduct.TabIndex = 1;
            this.tabScanProduct.Text = "Scan Product";
            this.tabScanProduct.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalPrice);
            this.panel1.Controls.Add(this.grvScanProducts);
            this.panel1.Controls.Add(this.lblAddProduct);
            this.panel1.Controls.Add(this._numDrUnitPrice);
            this.panel1.Controls.Add(this._numDrBulkQuantity);
            this.panel1.Controls.Add(this._numDrBulkPrice);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblBulkPrice);
            this.panel1.Controls.Add(this.lblBulkQuantity);
            this.panel1.Controls.Add(this.lblUnitPrice);
            this.panel1.Controls.Add(this.txtProductCode);
            this.panel1.Controls.Add(this.lblProductCode);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 579);
            this.panel1.TabIndex = 0;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(45, 89);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(75, 13);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Product Code:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(126, 86);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(125, 20);
            this.txtProductCode.TabIndex = 1;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(45, 128);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // lblBulkQuantity
            // 
            this.lblBulkQuantity.AutoSize = true;
            this.lblBulkQuantity.Location = new System.Drawing.Point(45, 171);
            this.lblBulkQuantity.Name = "lblBulkQuantity";
            this.lblBulkQuantity.Size = new System.Drawing.Size(58, 13);
            this.lblBulkQuantity.TabIndex = 4;
            this.lblBulkQuantity.Text = "Bulk Price:";
            // 
            // lblBulkPrice
            // 
            this.lblBulkPrice.AutoSize = true;
            this.lblBulkPrice.Location = new System.Drawing.Point(45, 214);
            this.lblBulkPrice.Name = "lblBulkPrice";
            this.lblBulkPrice.Size = new System.Drawing.Size(73, 13);
            this.lblBulkPrice.TabIndex = 6;
            this.lblBulkPrice.Text = "Bulk Quantity:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // _numDrBulkPrice
            // 
            this._numDrBulkPrice.DecimalPlaces = 2;
            this._numDrBulkPrice.Location = new System.Drawing.Point(126, 171);
            this._numDrBulkPrice.Name = "_numDrBulkPrice";
            this._numDrBulkPrice.Size = new System.Drawing.Size(120, 20);
            this._numDrBulkPrice.TabIndex = 10;
            // 
            // _numDrBulkQuantity
            // 
            this._numDrBulkQuantity.Location = new System.Drawing.Point(126, 212);
            this._numDrBulkQuantity.Name = "_numDrBulkQuantity";
            this._numDrBulkQuantity.Size = new System.Drawing.Size(120, 20);
            this._numDrBulkQuantity.TabIndex = 11;
            // 
            // _numDrUnitPrice
            // 
            this._numDrUnitPrice.DecimalPlaces = 2;
            this._numDrUnitPrice.Location = new System.Drawing.Point(126, 128);
            this._numDrUnitPrice.Name = "_numDrUnitPrice";
            this._numDrUnitPrice.Size = new System.Drawing.Size(120, 20);
            this._numDrUnitPrice.TabIndex = 12;
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.Location = new System.Drawing.Point(96, 31);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(126, 24);
            this.lblAddProduct.TabIndex = 13;
            this.lblAddProduct.Text = "Add Product";
            // 
            // grvScanProducts
            // 
            this.grvScanProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvScanProducts.Location = new System.Drawing.Point(281, 75);
            this.grvScanProducts.Name = "grvScanProducts";
            this.grvScanProducts.Size = new System.Drawing.Size(673, 205);
            this.grvScanProducts.TabIndex = 14;
            this.grvScanProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvScanProducts_CellClick);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(779, 305);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(116, 24);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 688);
            this.Controls.Add(this.tabPointOfSale);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPointOfSale.ResumeLayout(false);
            this.tabAddProduct.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numDrBulkPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrBulkQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvScanProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPointOfSale;
        private System.Windows.Forms.TabPage tabAddProduct;
        private System.Windows.Forms.TabPage tabScanProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBulkPrice;
        private System.Windows.Forms.Label lblBulkQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.NumericUpDown _numDrUnitPrice;
        private System.Windows.Forms.NumericUpDown _numDrBulkQuantity;
        private System.Windows.Forms.NumericUpDown _numDrBulkPrice;
        private System.Windows.Forms.DataGridView grvScanProducts;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}

