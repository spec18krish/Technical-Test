﻿namespace Voyager
{
    partial class POSForm
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
            this.pnlPOS = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.grvScanProducts = new System.Windows.Forms.DataGridView();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this._numDrUnitPrice = new System.Windows.Forms.NumericUpDown();
            this._numDrBulkQuantity = new System.Windows.Forms.NumericUpDown();
            this._numDrBulkPrice = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBulkPrice = new System.Windows.Forms.Label();
            this.lblBulkQuantity = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblUpdateProduct = new System.Windows.Forms.Label();
            this._numDrUpdateUnitPrice = new System.Windows.Forms.NumericUpDown();
            this._numDrUpdateBulkQuantity = new System.Windows.Forms.NumericUpDown();
            this._numDrUpdateBulkPrice = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateBulkQuantity = new System.Windows.Forms.Label();
            this.lblUpdateBulkPrice = new System.Windows.Forms.Label();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdateProductCode = new System.Windows.Forms.Label();
            this.cmbProductCode = new System.Windows.Forms.ComboBox();
            this.lblScanProducts = new System.Windows.Forms.Label();
            this.lblVoyagerTechnicalTest = new System.Windows.Forms.Label();
            this.pnlPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvScanProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrBulkQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrBulkPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUpdateUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUpdateBulkQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUpdateBulkPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPOS
            // 
            this.pnlPOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPOS.Controls.Add(this.lblScanProducts);
            this.pnlPOS.Controls.Add(this.cmbProductCode);
            this.pnlPOS.Controls.Add(this.lblUpdateProduct);
            this.pnlPOS.Controls.Add(this._numDrUpdateUnitPrice);
            this.pnlPOS.Controls.Add(this._numDrUpdateBulkQuantity);
            this.pnlPOS.Controls.Add(this._numDrUpdateBulkPrice);
            this.pnlPOS.Controls.Add(this.btnUpdate);
            this.pnlPOS.Controls.Add(this.lblUpdateBulkQuantity);
            this.pnlPOS.Controls.Add(this.lblUpdateBulkPrice);
            this.pnlPOS.Controls.Add(this.lblUpdateUnitPrice);
            this.pnlPOS.Controls.Add(this.lblUpdateProductCode);
            this.pnlPOS.Controls.Add(this.lblTotalPrice);
            this.pnlPOS.Controls.Add(this.grvScanProducts);
            this.pnlPOS.Controls.Add(this.lblAddProduct);
            this.pnlPOS.Controls.Add(this._numDrUnitPrice);
            this.pnlPOS.Controls.Add(this._numDrBulkQuantity);
            this.pnlPOS.Controls.Add(this._numDrBulkPrice);
            this.pnlPOS.Controls.Add(this.btnCancel);
            this.pnlPOS.Controls.Add(this.btnAdd);
            this.pnlPOS.Controls.Add(this.lblBulkPrice);
            this.pnlPOS.Controls.Add(this.lblBulkQuantity);
            this.pnlPOS.Controls.Add(this.lblUnitPrice);
            this.pnlPOS.Controls.Add(this.txtProductCode);
            this.pnlPOS.Controls.Add(this.lblProductCode);
            this.pnlPOS.Location = new System.Drawing.Point(51, 90);
            this.pnlPOS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPOS.Name = "pnlPOS";
            this.pnlPOS.Size = new System.Drawing.Size(1472, 713);
            this.pnlPOS.TabIndex = 0;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(1084, 370);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(154, 31);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // grvScanProducts
            // 
            this.grvScanProducts.AllowUserToAddRows = false;
            this.grvScanProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvScanProducts.Location = new System.Drawing.Point(375, 92);
            this.grvScanProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grvScanProducts.Name = "grvScanProducts";
            this.grvScanProducts.RowHeadersWidth = 51;
            this.grvScanProducts.Size = new System.Drawing.Size(1003, 252);
            this.grvScanProducts.TabIndex = 14;
            this.grvScanProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvScanProducts_CellClick);
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.Location = new System.Drawing.Point(128, 38);
            this.lblAddProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(164, 31);
            this.lblAddProduct.TabIndex = 13;
            this.lblAddProduct.Text = "Add Product";
            // 
            // _numDrUnitPrice
            // 
            this._numDrUnitPrice.DecimalPlaces = 2;
            this._numDrUnitPrice.Location = new System.Drawing.Point(168, 158);
            this._numDrUnitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._numDrUnitPrice.Name = "_numDrUnitPrice";
            this._numDrUnitPrice.Size = new System.Drawing.Size(160, 22);
            this._numDrUnitPrice.TabIndex = 12;
            // 
            // _numDrBulkQuantity
            // 
            this._numDrBulkQuantity.Location = new System.Drawing.Point(168, 261);
            this._numDrBulkQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._numDrBulkQuantity.Name = "_numDrBulkQuantity";
            this._numDrBulkQuantity.Size = new System.Drawing.Size(160, 22);
            this._numDrBulkQuantity.TabIndex = 11;
            // 
            // _numDrBulkPrice
            // 
            this._numDrBulkPrice.DecimalPlaces = 2;
            this._numDrBulkPrice.Location = new System.Drawing.Point(168, 210);
            this._numDrBulkPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._numDrBulkPrice.Name = "_numDrBulkPrice";
            this._numDrBulkPrice.Size = new System.Drawing.Size(160, 22);
            this._numDrBulkPrice.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 316);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 316);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBulkPrice
            // 
            this.lblBulkPrice.AutoSize = true;
            this.lblBulkPrice.Location = new System.Drawing.Point(60, 263);
            this.lblBulkPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBulkPrice.Name = "lblBulkPrice";
            this.lblBulkPrice.Size = new System.Drawing.Size(96, 17);
            this.lblBulkPrice.TabIndex = 6;
            this.lblBulkPrice.Text = "Bulk Quantity:";
            // 
            // lblBulkQuantity
            // 
            this.lblBulkQuantity.AutoSize = true;
            this.lblBulkQuantity.Location = new System.Drawing.Point(60, 210);
            this.lblBulkQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBulkQuantity.Name = "lblBulkQuantity";
            this.lblBulkQuantity.Size = new System.Drawing.Size(75, 17);
            this.lblBulkQuantity.TabIndex = 4;
            this.lblBulkQuantity.Text = "Bulk Price:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(60, 158);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(73, 17);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(168, 106);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(165, 22);
            this.txtProductCode.TabIndex = 1;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(60, 110);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(98, 17);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Product Code:";
            // 
            // lblUpdateProduct
            // 
            this.lblUpdateProduct.AutoSize = true;
            this.lblUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateProduct.Location = new System.Drawing.Point(92, 392);
            this.lblUpdateProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateProduct.Name = "lblUpdateProduct";
            this.lblUpdateProduct.Size = new System.Drawing.Size(201, 31);
            this.lblUpdateProduct.TabIndex = 26;
            this.lblUpdateProduct.Text = "Update Product";
            // 
            // _numDrUpdateUnitPrice
            // 
            this._numDrUpdateUnitPrice.DecimalPlaces = 2;
            this._numDrUpdateUnitPrice.Location = new System.Drawing.Point(168, 507);
            this._numDrUpdateUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this._numDrUpdateUnitPrice.Name = "_numDrUpdateUnitPrice";
            this._numDrUpdateUnitPrice.Size = new System.Drawing.Size(160, 22);
            this._numDrUpdateUnitPrice.TabIndex = 25;
            // 
            // _numDrUpdateBulkQuantity
            // 
            this._numDrUpdateBulkQuantity.Location = new System.Drawing.Point(168, 610);
            this._numDrUpdateBulkQuantity.Margin = new System.Windows.Forms.Padding(4);
            this._numDrUpdateBulkQuantity.Name = "_numDrUpdateBulkQuantity";
            this._numDrUpdateBulkQuantity.Size = new System.Drawing.Size(160, 22);
            this._numDrUpdateBulkQuantity.TabIndex = 24;
            // 
            // _numDrUpdateBulkPrice
            // 
            this._numDrUpdateBulkPrice.DecimalPlaces = 2;
            this._numDrUpdateBulkPrice.Location = new System.Drawing.Point(168, 559);
            this._numDrUpdateBulkPrice.Margin = new System.Windows.Forms.Padding(4);
            this._numDrUpdateBulkPrice.Name = "_numDrUpdateBulkPrice";
            this._numDrUpdateBulkPrice.Size = new System.Drawing.Size(160, 22);
            this._numDrUpdateBulkPrice.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(149, 665);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateBulkQuantity
            // 
            this.lblUpdateBulkQuantity.AutoSize = true;
            this.lblUpdateBulkQuantity.Location = new System.Drawing.Point(60, 612);
            this.lblUpdateBulkQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateBulkQuantity.Name = "lblUpdateBulkQuantity";
            this.lblUpdateBulkQuantity.Size = new System.Drawing.Size(96, 17);
            this.lblUpdateBulkQuantity.TabIndex = 20;
            this.lblUpdateBulkQuantity.Text = "Bulk Quantity:";
            // 
            // lblUpdateBulkPrice
            // 
            this.lblUpdateBulkPrice.AutoSize = true;
            this.lblUpdateBulkPrice.Location = new System.Drawing.Point(60, 559);
            this.lblUpdateBulkPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateBulkPrice.Name = "lblUpdateBulkPrice";
            this.lblUpdateBulkPrice.Size = new System.Drawing.Size(75, 17);
            this.lblUpdateBulkPrice.TabIndex = 19;
            this.lblUpdateBulkPrice.Text = "Bulk Price:";
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(60, 507);
            this.lblUpdateUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(73, 17);
            this.lblUpdateUnitPrice.TabIndex = 18;
            this.lblUpdateUnitPrice.Text = "Unit Price:";
            // 
            // lblUpdateProductCode
            // 
            this.lblUpdateProductCode.AutoSize = true;
            this.lblUpdateProductCode.Location = new System.Drawing.Point(60, 459);
            this.lblUpdateProductCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateProductCode.Name = "lblUpdateProductCode";
            this.lblUpdateProductCode.Size = new System.Drawing.Size(98, 17);
            this.lblUpdateProductCode.TabIndex = 16;
            this.lblUpdateProductCode.Text = "Product Code:";
            // 
            // cmbProductCode
            // 
            this.cmbProductCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductCode.Location = new System.Drawing.Point(168, 459);
            this.cmbProductCode.Name = "cmbProductCode";
            this.cmbProductCode.Size = new System.Drawing.Size(160, 24);
            this.cmbProductCode.TabIndex = 27;
            this.cmbProductCode.SelectedIndexChanged += new System.EventHandler(this.cmbProductCode_SelectedIndexChanged);
            // 
            // lblScanProducts
            // 
            this.lblScanProducts.AutoSize = true;
            this.lblScanProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanProducts.Location = new System.Drawing.Point(788, 38);
            this.lblScanProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScanProducts.Name = "lblScanProducts";
            this.lblScanProducts.Size = new System.Drawing.Size(191, 31);
            this.lblScanProducts.TabIndex = 28;
            this.lblScanProducts.Text = "Scan Products";
            // 
            // lblVoyagerTechnicalTest
            // 
            this.lblVoyagerTechnicalTest.AutoSize = true;
            this.lblVoyagerTechnicalTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoyagerTechnicalTest.Location = new System.Drawing.Point(746, 35);
            this.lblVoyagerTechnicalTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoyagerTechnicalTest.Name = "lblVoyagerTechnicalTest";
            this.lblVoyagerTechnicalTest.Size = new System.Drawing.Size(303, 31);
            this.lblVoyagerTechnicalTest.TabIndex = 29;
            this.lblVoyagerTechnicalTest.Text = "Voyager Technical Test";
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 855);
            this.Controls.Add(this.lblVoyagerTechnicalTest);
            this.Controls.Add(this.pnlPOS);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "POSForm";
            this.Text = "Point of Sale";
            this.pnlPOS.ResumeLayout(false);
            this.pnlPOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvScanProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrBulkQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrBulkPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUpdateUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUpdateBulkQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUpdateBulkPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlPOS;
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
        private System.Windows.Forms.Label lblUpdateProduct;
        private System.Windows.Forms.NumericUpDown _numDrUpdateUnitPrice;
        private System.Windows.Forms.NumericUpDown _numDrUpdateBulkQuantity;
        private System.Windows.Forms.NumericUpDown _numDrUpdateBulkPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdateBulkQuantity;
        private System.Windows.Forms.Label lblUpdateBulkPrice;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.Label lblUpdateProductCode;
        private System.Windows.Forms.ComboBox cmbProductCode;
        private System.Windows.Forms.Label lblScanProducts;
        private System.Windows.Forms.Label lblVoyagerTechnicalTest;
    }
}

