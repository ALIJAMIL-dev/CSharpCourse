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
            this.gbxNameSearch = new System.Windows.Forms.GroupBox();
            this.lblCategorySearch = new System.Windows.Forms.Label();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.cbxCategorySearch = new System.Windows.Forms.ComboBox();
            this.tbxNameSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbxCategorySearch.SuspendLayout();
            this.gbxNameSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 227);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 26;
            this.dgvProducts.Size = new System.Drawing.Size(919, 330);
            this.dgvProducts.TabIndex = 0;
            // 
            // gbxCategorySearch
            // 
            this.gbxCategorySearch.Controls.Add(this.cbxCategorySearch);
            this.gbxCategorySearch.Controls.Add(this.lblCategorySearch);
            this.gbxCategorySearch.Location = new System.Drawing.Point(12, 12);
            this.gbxCategorySearch.Name = "gbxCategorySearch";
            this.gbxCategorySearch.Size = new System.Drawing.Size(919, 95);
            this.gbxCategorySearch.TabIndex = 1;
            this.gbxCategorySearch.TabStop = false;
            this.gbxCategorySearch.Text = "Category Search";
            // 
            // gbxNameSearch
            // 
            this.gbxNameSearch.Controls.Add(this.tbxNameSearch);
            this.gbxNameSearch.Controls.Add(this.lblNameSearch);
            this.gbxNameSearch.Location = new System.Drawing.Point(12, 128);
            this.gbxNameSearch.Name = "gbxNameSearch";
            this.gbxNameSearch.Size = new System.Drawing.Size(919, 93);
            this.gbxNameSearch.TabIndex = 2;
            this.gbxNameSearch.TabStop = false;
            this.gbxNameSearch.Text = "Name Search";
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
            // lblNameSearch
            // 
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.Location = new System.Drawing.Point(7, 49);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(43, 17);
            this.lblNameSearch.TabIndex = 1;
            this.lblNameSearch.Text = "Name";
            // 
            // cbxCategorySearch
            // 
            this.cbxCategorySearch.FormattingEnabled = true;
            this.cbxCategorySearch.Location = new System.Drawing.Point(80, 42);
            this.cbxCategorySearch.Name = "cbxCategorySearch";
            this.cbxCategorySearch.Size = new System.Drawing.Size(601, 24);
            this.cbxCategorySearch.TabIndex = 1;
            // 
            // tbxNameSearch
            // 
            this.tbxNameSearch.Location = new System.Drawing.Point(80, 49);
            this.tbxNameSearch.Name = "tbxNameSearch";
            this.tbxNameSearch.Size = new System.Drawing.Size(601, 24);
            this.tbxNameSearch.TabIndex = 2;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 564);
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
    }
}

