namespace _4_hw_11._04._2023_Forms
{
    partial class MainForm
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
            this.buttonGasStation = new System.Windows.Forms.Button();
            this.buttonCafe = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGasStation
            // 
            this.buttonGasStation.Location = new System.Drawing.Point(29, 17);
            this.buttonGasStation.Name = "buttonGasStation";
            this.buttonGasStation.Size = new System.Drawing.Size(157, 34);
            this.buttonGasStation.TabIndex = 1;
            this.buttonGasStation.Text = "Автозаправка";
            this.buttonGasStation.UseVisualStyleBackColor = true;
            this.buttonGasStation.Click += new System.EventHandler(this.buttonGasStation_Click);
            // 
            // buttonCafe
            // 
            this.buttonCafe.Location = new System.Drawing.Point(29, 57);
            this.buttonCafe.Name = "buttonCafe";
            this.buttonCafe.Size = new System.Drawing.Size(157, 34);
            this.buttonCafe.TabIndex = 2;
            this.buttonCafe.Text = "Кафе";
            this.buttonCafe.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(29, 97);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(157, 34);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Редактирование";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(215, 143);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCafe);
            this.Controls.Add(this.buttonGasStation);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BestOil";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonGasStation;
        private System.Windows.Forms.Button buttonCafe;
        private System.Windows.Forms.Button buttonEdit;
    }
}

