namespace _2_UrunlerListele
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
            this.btnListProducts = new System.Windows.Forms.Button();
            this.btnListCategories = new System.Windows.Forms.Button();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitsInStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnListProducts
            // 
            this.btnListProducts.Location = new System.Drawing.Point(54, 283);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(103, 27);
            this.btnListProducts.TabIndex = 1;
            this.btnListProducts.Text = "List Products";
            this.btnListProducts.UseVisualStyleBackColor = true;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
            // 
            // btnListCategories
            // 
            this.btnListCategories.Location = new System.Drawing.Point(232, 282);
            this.btnListCategories.Name = "btnListCategories";
            this.btnListCategories.Size = new System.Drawing.Size(103, 27);
            this.btnListCategories.TabIndex = 3;
            this.btnListCategories.Text = "List Categories";
            this.btnListCategories.UseVisualStyleBackColor = true;
            this.btnListCategories.Click += new System.EventHandler(this.btnListCategories_Click);
            // 
            // lbCategories
            // 
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.HorizontalScrollbar = true;
            this.lbCategories.Location = new System.Drawing.Point(202, 12);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(169, 264);
            this.lbCategories.TabIndex = 2;
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productName,
            this.unitPrice,
            this.unitsInStock});
            this.lvProducts.Location = new System.Drawing.Point(12, 12);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(184, 265);
            this.lvProducts.TabIndex = 4;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // productName
            // 
            this.productName.Text = "Product Name";
            // 
            // unitPrice
            // 
            this.unitPrice.Text = "Unit Price";
            // 
            // unitsInStock
            // 
            this.unitsInStock.Text = "Units In Stock";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 332);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.btnListCategories);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.btnListProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListProducts;
        private System.Windows.Forms.Button btnListCategories;
        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader unitPrice;
        private System.Windows.Forms.ColumnHeader unitsInStock;
    }
}

