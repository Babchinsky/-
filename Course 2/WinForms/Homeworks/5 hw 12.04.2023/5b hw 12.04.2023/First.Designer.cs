namespace _5b_hw_12._04._2023
{
    partial class First
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
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.comboBoxAllProducts = new System.Windows.Forms.ComboBox();
            this.textBoxPriceForProduct = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.buttonToSelected = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.Location = new System.Drawing.Point(13, 13);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(120, 160);
            this.listBoxSelected.TabIndex = 0;
            // 
            // comboBoxAllProducts
            // 
            this.comboBoxAllProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAllProducts.FormattingEnabled = true;
            this.comboBoxAllProducts.Location = new System.Drawing.Point(139, 12);
            this.comboBoxAllProducts.Name = "comboBoxAllProducts";
            this.comboBoxAllProducts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAllProducts.TabIndex = 1;
            this.comboBoxAllProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxAllProducts_SelectedIndexChanged);
            // 
            // textBoxPriceForProduct
            // 
            this.textBoxPriceForProduct.Location = new System.Drawing.Point(139, 39);
            this.textBoxPriceForProduct.Name = "textBoxPriceForProduct";
            this.textBoxPriceForProduct.ReadOnly = true;
            this.textBoxPriceForProduct.Size = new System.Drawing.Size(121, 20);
            this.textBoxPriceForProduct.TabIndex = 2;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(12, 180);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxTotalPrice.TabIndex = 4;
            // 
            // buttonToSelected
            // 
            this.buttonToSelected.Location = new System.Drawing.Point(139, 65);
            this.buttonToSelected.Name = "buttonToSelected";
            this.buttonToSelected.Size = new System.Drawing.Size(121, 23);
            this.buttonToSelected.TabIndex = 5;
            this.buttonToSelected.Text = "В корзину";
            this.buttonToSelected.UseVisualStyleBackColor = true;
            this.buttonToSelected.Click += new System.EventHandler(this.buttonToSelected_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(139, 94);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Убрать из корзины";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 212);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonToSelected);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.textBoxPriceForProduct);
            this.Controls.Add(this.comboBoxAllProducts);
            this.Controls.Add(this.listBoxSelected);
            this.MaximizeBox = false;
            this.Name = "First";
            this.Text = "Configure PC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSelected;
        private System.Windows.Forms.ComboBox comboBoxAllProducts;
        private System.Windows.Forms.TextBox textBoxPriceForProduct;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Button buttonToSelected;
        private System.Windows.Forms.Button buttonDelete;
    }
}