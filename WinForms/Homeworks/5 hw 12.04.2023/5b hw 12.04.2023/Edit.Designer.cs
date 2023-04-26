namespace _5b_hw_12._04._2023
{
    partial class Edit
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonToSelected = new System.Windows.Forms.Button();
            this.textBoxPriceForProduct = new System.Windows.Forms.TextBox();
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(138, 93);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Редактировать";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonToSelected
            // 
            this.buttonToSelected.Location = new System.Drawing.Point(138, 64);
            this.buttonToSelected.Name = "buttonToSelected";
            this.buttonToSelected.Size = new System.Drawing.Size(121, 23);
            this.buttonToSelected.TabIndex = 10;
            this.buttonToSelected.Text = "Добаавить";
            this.buttonToSelected.UseVisualStyleBackColor = true;
            // 
            // textBoxPriceForProduct
            // 
            this.textBoxPriceForProduct.Location = new System.Drawing.Point(138, 38);
            this.textBoxPriceForProduct.Name = "textBoxPriceForProduct";
            this.textBoxPriceForProduct.Size = new System.Drawing.Size(121, 20);
            this.textBoxPriceForProduct.TabIndex = 9;
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.Location = new System.Drawing.Point(12, 12);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(120, 160);
            this.listBoxSelected.TabIndex = 7;
            this.listBoxSelected.SelectedIndexChanged += new System.EventHandler(this.listBoxSelected_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Убрать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 188);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonToSelected);
            this.Controls.Add(this.textBoxPriceForProduct);
            this.Controls.Add(this.listBoxSelected);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonToSelected;
        private System.Windows.Forms.TextBox textBoxPriceForProduct;
        private System.Windows.Forms.ListBox listBoxSelected;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}