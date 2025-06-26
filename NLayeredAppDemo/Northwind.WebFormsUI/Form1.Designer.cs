namespace Northwind.WebFormsUI
{
    partial class Products
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.gbxCategorySearch = new System.Windows.Forms.GroupBox();
            this.cbxCategorySearch = new System.Windows.Forms.ComboBox();
            this.lblCategorySearch = new System.Windows.Forms.Label();
            this.gbxNameSearch = new System.Windows.Forms.GroupBox();
            this.tbxNameSearch = new System.Windows.Forms.TextBox();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.lblAddCategoryID = new System.Windows.Forms.Label();
            this.lblAddUnitPrice = new System.Windows.Forms.Label();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.cbxAddCategoryID = new System.Windows.Forms.ComboBox();
            this.tbxAddUnitPrice = new System.Windows.Forms.TextBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxUpdateCategoryID = new System.Windows.Forms.ComboBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdateCategoryID = new System.Windows.Forms.Label();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.btnUpdateSave = new System.Windows.Forms.Button();
            this.tbxUpdateStock = new System.Windows.Forms.TextBox();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.lblUpdateQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblupdateStock = new System.Windows.Forms.Label();
            this.btnDeleteSave = new System.Windows.Forms.Button();
            this.gbxDelete = new System.Windows.Forms.GroupBox();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.tbxAddStock = new System.Windows.Forms.TextBox();
            this.tbxAddQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.lblAddQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblAddStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbxCategorySearch.SuspendLayout();
            this.gbxNameSearch.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 228);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 26;
            this.dgvProducts.Size = new System.Drawing.Size(827, 330);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // gbxCategorySearch
            // 
            this.gbxCategorySearch.Controls.Add(this.cbxCategorySearch);
            this.gbxCategorySearch.Controls.Add(this.lblCategorySearch);
            this.gbxCategorySearch.Location = new System.Drawing.Point(12, 12);
            this.gbxCategorySearch.Name = "gbxCategorySearch";
            this.gbxCategorySearch.Size = new System.Drawing.Size(681, 95);
            this.gbxCategorySearch.TabIndex = 1;
            this.gbxCategorySearch.TabStop = false;
            this.gbxCategorySearch.Text = "Category Search";
            // 
            // cbxCategorySearch
            // 
            this.cbxCategorySearch.FormattingEnabled = true;
            this.cbxCategorySearch.Location = new System.Drawing.Point(80, 42);
            this.cbxCategorySearch.Name = "cbxCategorySearch";
            this.cbxCategorySearch.Size = new System.Drawing.Size(573, 24);
            this.cbxCategorySearch.TabIndex = 1;
            this.cbxCategorySearch.SelectedIndexChanged += new System.EventHandler(this.cbxCategorySearch_SelectedIndexChanged);
            // 
            // lblCategorySearch
            // 
            this.lblCategorySearch.AutoSize = true;
            this.lblCategorySearch.Location = new System.Drawing.Point(7, 42);
            this.lblCategorySearch.Name = "lblCategorySearch";
            this.lblCategorySearch.Size = new System.Drawing.Size(65, 17);
            this.lblCategorySearch.TabIndex = 0;
            this.lblCategorySearch.Text = "Category";
            // 
            // gbxNameSearch
            // 
            this.gbxNameSearch.Controls.Add(this.tbxNameSearch);
            this.gbxNameSearch.Controls.Add(this.lblNameSearch);
            this.gbxNameSearch.Location = new System.Drawing.Point(12, 128);
            this.gbxNameSearch.Name = "gbxNameSearch";
            this.gbxNameSearch.Size = new System.Drawing.Size(681, 93);
            this.gbxNameSearch.TabIndex = 2;
            this.gbxNameSearch.TabStop = false;
            this.gbxNameSearch.Text = "Name Search";
            // 
            // tbxNameSearch
            // 
            this.tbxNameSearch.Location = new System.Drawing.Point(80, 49);
            this.tbxNameSearch.Name = "tbxNameSearch";
            this.tbxNameSearch.Size = new System.Drawing.Size(573, 24);
            this.tbxNameSearch.TabIndex = 2;
            this.tbxNameSearch.TextChanged += new System.EventHandler(this.tbxNameSearch_TextChanged);
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.Location = new System.Drawing.Point(7, 49);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(43, 17);
            this.lblNameSearch.TabIndex = 1;
            this.lblNameSearch.Text = "Name";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAddSave);
            this.gbxProductAdd.Controls.Add(this.tbxAddStock);
            this.gbxProductAdd.Controls.Add(this.tbxAddQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblAddQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblAddStock);
            this.gbxProductAdd.Controls.Add(this.tbxAddUnitPrice);
            this.gbxProductAdd.Controls.Add(this.cbxAddCategoryID);
            this.gbxProductAdd.Controls.Add(this.tbxAddProductName);
            this.gbxProductAdd.Controls.Add(this.lblAddUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblAddCategoryID);
            this.gbxProductAdd.Controls.Add(this.lblAddProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(845, 298);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(445, 260);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Add Product";
            this.gbxProductAdd.Enter += new System.EventHandler(this.gbxProductAdd_Enter);
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(8, 34);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(96, 17);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Product Name";
            // 
            // lblAddCategoryID
            // 
            this.lblAddCategoryID.AutoSize = true;
            this.lblAddCategoryID.Location = new System.Drawing.Point(8, 78);
            this.lblAddCategoryID.Name = "lblAddCategoryID";
            this.lblAddCategoryID.Size = new System.Drawing.Size(65, 17);
            this.lblAddCategoryID.TabIndex = 1;
            this.lblAddCategoryID.Text = "Category";
            // 
            // lblAddUnitPrice
            // 
            this.lblAddUnitPrice.AutoSize = true;
            this.lblAddUnitPrice.Location = new System.Drawing.Point(8, 111);
            this.lblAddUnitPrice.Name = "lblAddUnitPrice";
            this.lblAddUnitPrice.Size = new System.Drawing.Size(65, 17);
            this.lblAddUnitPrice.TabIndex = 2;
            this.lblAddUnitPrice.Text = "Unit Price";
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(138, 34);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(295, 24);
            this.tbxAddProductName.TabIndex = 5;
            // 
            // cbxAddCategoryID
            // 
            this.cbxAddCategoryID.FormattingEnabled = true;
            this.cbxAddCategoryID.Location = new System.Drawing.Point(138, 71);
            this.cbxAddCategoryID.Name = "cbxAddCategoryID";
            this.cbxAddCategoryID.Size = new System.Drawing.Size(295, 24);
            this.cbxAddCategoryID.TabIndex = 6;
            // 
            // tbxAddUnitPrice
            // 
            this.tbxAddUnitPrice.Location = new System.Drawing.Point(138, 108);
            this.tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            this.tbxAddUnitPrice.Size = new System.Drawing.Size(295, 24);
            this.tbxAddUnitPrice.TabIndex = 8;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdateSave);
            this.gbxUpdate.Controls.Add(this.tbxUpdateStock);
            this.gbxUpdate.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.gbxUpdate.Controls.Add(this.lblUpdateQuantityPerUnit);
            this.gbxUpdate.Controls.Add(this.lblupdateStock);
            this.gbxUpdate.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxUpdate.Controls.Add(this.cbxUpdateCategoryID);
            this.gbxUpdate.Controls.Add(this.tbxUpdateProductName);
            this.gbxUpdate.Controls.Add(this.lblUpdateUnitPrice);
            this.gbxUpdate.Controls.Add(this.lblUpdateCategoryID);
            this.gbxUpdate.Controls.Add(this.lblUpdateProductName);
            this.gbxUpdate.Location = new System.Drawing.Point(845, 12);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(445, 267);
            this.gbxUpdate.TabIndex = 4;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update Product";
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(138, 108);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(295, 24);
            this.tbxUpdateUnitPrice.TabIndex = 8;
            // 
            // cbxUpdateCategoryID
            // 
            this.cbxUpdateCategoryID.FormattingEnabled = true;
            this.cbxUpdateCategoryID.Location = new System.Drawing.Point(138, 71);
            this.cbxUpdateCategoryID.Name = "cbxUpdateCategoryID";
            this.cbxUpdateCategoryID.Size = new System.Drawing.Size(295, 24);
            this.cbxUpdateCategoryID.TabIndex = 6;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(138, 34);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(295, 24);
            this.tbxUpdateProductName.TabIndex = 5;
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(8, 111);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(65, 17);
            this.lblUpdateUnitPrice.TabIndex = 2;
            this.lblUpdateUnitPrice.Text = "Unit Price";
            // 
            // lblUpdateCategoryID
            // 
            this.lblUpdateCategoryID.AutoSize = true;
            this.lblUpdateCategoryID.Location = new System.Drawing.Point(8, 78);
            this.lblUpdateCategoryID.Name = "lblUpdateCategoryID";
            this.lblUpdateCategoryID.Size = new System.Drawing.Size(65, 17);
            this.lblUpdateCategoryID.TabIndex = 1;
            this.lblUpdateCategoryID.Text = "Category";
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Location = new System.Drawing.Point(8, 34);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(96, 17);
            this.lblUpdateProductName.TabIndex = 0;
            this.lblUpdateProductName.Text = "Product Name";
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.Location = new System.Drawing.Point(138, 215);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(295, 23);
            this.btnUpdateSave.TabIndex = 15;
            this.btnUpdateSave.Text = "Update the Product";
            this.btnUpdateSave.UseVisualStyleBackColor = true;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // tbxUpdateStock
            // 
            this.tbxUpdateStock.Location = new System.Drawing.Point(138, 138);
            this.tbxUpdateStock.Name = "tbxUpdateStock";
            this.tbxUpdateStock.Size = new System.Drawing.Size(295, 24);
            this.tbxUpdateStock.TabIndex = 14;
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(138, 175);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(295, 24);
            this.tbxUpdateQuantityPerUnit.TabIndex = 13;
            // 
            // lblUpdateQuantityPerUnit
            // 
            this.lblUpdateQuantityPerUnit.AutoSize = true;
            this.lblUpdateQuantityPerUnit.Location = new System.Drawing.Point(8, 182);
            this.lblUpdateQuantityPerUnit.Name = "lblUpdateQuantityPerUnit";
            this.lblUpdateQuantityPerUnit.Size = new System.Drawing.Size(113, 17);
            this.lblUpdateQuantityPerUnit.TabIndex = 12;
            this.lblUpdateQuantityPerUnit.Text = "Quantity Per Unit";
            // 
            // lblupdateStock
            // 
            this.lblupdateStock.AutoSize = true;
            this.lblupdateStock.Location = new System.Drawing.Point(8, 145);
            this.lblupdateStock.Name = "lblupdateStock";
            this.lblupdateStock.Size = new System.Drawing.Size(96, 17);
            this.lblupdateStock.TabIndex = 11;
            this.lblupdateStock.Text = "Stock Amount";
            // 
            // btnDeleteSave
            // 
            this.btnDeleteSave.Location = new System.Drawing.Point(6, 70);
            this.btnDeleteSave.Name = "btnDeleteSave";
            this.btnDeleteSave.Size = new System.Drawing.Size(128, 57);
            this.btnDeleteSave.TabIndex = 5;
            this.btnDeleteSave.Text = "Delete the Product";
            this.btnDeleteSave.UseVisualStyleBackColor = true;
            this.btnDeleteSave.Click += new System.EventHandler(this.btnDeleteSave_Click);
            // 
            // gbxDelete
            // 
            this.gbxDelete.Controls.Add(this.btnDeleteSave);
            this.gbxDelete.Location = new System.Drawing.Point(699, 20);
            this.gbxDelete.Name = "gbxDelete";
            this.gbxDelete.Size = new System.Drawing.Size(140, 202);
            this.gbxDelete.TabIndex = 6;
            this.gbxDelete.TabStop = false;
            this.gbxDelete.Text = "Delete Product";
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(138, 230);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(295, 23);
            this.btnAddSave.TabIndex = 15;
            this.btnAddSave.Text = "Add the Product";
            this.btnAddSave.UseVisualStyleBackColor = true;
            // 
            // tbxAddStock
            // 
            this.tbxAddStock.Location = new System.Drawing.Point(138, 153);
            this.tbxAddStock.Name = "tbxAddStock";
            this.tbxAddStock.Size = new System.Drawing.Size(295, 24);
            this.tbxAddStock.TabIndex = 14;
            // 
            // tbxAddQuantityPerUnit
            // 
            this.tbxAddQuantityPerUnit.Location = new System.Drawing.Point(138, 190);
            this.tbxAddQuantityPerUnit.Name = "tbxAddQuantityPerUnit";
            this.tbxAddQuantityPerUnit.Size = new System.Drawing.Size(295, 24);
            this.tbxAddQuantityPerUnit.TabIndex = 13;
            // 
            // lblAddQuantityPerUnit
            // 
            this.lblAddQuantityPerUnit.AutoSize = true;
            this.lblAddQuantityPerUnit.Location = new System.Drawing.Point(8, 197);
            this.lblAddQuantityPerUnit.Name = "lblAddQuantityPerUnit";
            this.lblAddQuantityPerUnit.Size = new System.Drawing.Size(113, 17);
            this.lblAddQuantityPerUnit.TabIndex = 12;
            this.lblAddQuantityPerUnit.Text = "Quantity Per Unit";
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Location = new System.Drawing.Point(8, 153);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(96, 17);
            this.lblAddStock.TabIndex = 11;
            this.lblAddStock.Text = "Stock Amount";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 573);
            this.Controls.Add(this.gbxDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxNameSearch);
            this.Controls.Add(this.gbxCategorySearch);
            this.Controls.Add(this.dgvProducts);
            this.Name = "Products";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbxCategorySearch.ResumeLayout(false);
            this.gbxCategorySearch.PerformLayout();
            this.gbxNameSearch.ResumeLayout(false);
            this.gbxNameSearch.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox gbxCategorySearch;
        private System.Windows.Forms.ComboBox cbxCategorySearch;
        private System.Windows.Forms.Label lblCategorySearch;
        private System.Windows.Forms.GroupBox gbxNameSearch;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.TextBox tbxNameSearch;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblAddCategoryID;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.Label lblAddUnitPrice;
        private System.Windows.Forms.TextBox tbxAddUnitPrice;
        private System.Windows.Forms.ComboBox cbxAddCategoryID;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.ComboBox cbxUpdateCategoryID;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.Label lblUpdateCategoryID;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.Button btnUpdateSave;
        private System.Windows.Forms.TextBox tbxUpdateStock;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.Label lblUpdateQuantityPerUnit;
        private System.Windows.Forms.Label lblupdateStock;
        private System.Windows.Forms.Button btnDeleteSave;
        private System.Windows.Forms.GroupBox gbxDelete;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.TextBox tbxAddStock;
        private System.Windows.Forms.TextBox tbxAddQuantityPerUnit;
        private System.Windows.Forms.Label lblAddQuantityPerUnit;
        private System.Windows.Forms.Label lblAddStock;
    }
}

