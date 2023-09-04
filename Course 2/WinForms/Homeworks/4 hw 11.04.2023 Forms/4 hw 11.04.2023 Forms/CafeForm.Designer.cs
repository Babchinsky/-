namespace _4_hw_11._04._2023_Forms
{
    partial class CafeForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCountCola = new System.Windows.Forms.TextBox();
            this.textBoxPriceCola = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBoxCountFry = new System.Windows.Forms.TextBox();
            this.textBoxPriceFry = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBoxCountBurger = new System.Windows.Forms.TextBox();
            this.textBoxPriceBurger = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBoxCountHotDog = new System.Windows.Forms.TextBox();
            this.textBoxPriceHotDog = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxPayableToCafe = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCountCola);
            this.groupBox2.Controls.Add(this.textBoxPriceCola);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.textBoxCountFry);
            this.groupBox2.Controls.Add(this.textBoxPriceFry);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.textBoxCountBurger);
            this.groupBox2.Controls.Add(this.textBoxPriceBurger);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.textBoxCountHotDog);
            this.groupBox2.Controls.Add(this.textBoxPriceHotDog);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 259);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кафе";
            // 
            // textBoxCountCola
            // 
            this.textBoxCountCola.Enabled = false;
            this.textBoxCountCola.Location = new System.Drawing.Point(150, 110);
            this.textBoxCountCola.Name = "textBoxCountCola";
            this.textBoxCountCola.Size = new System.Drawing.Size(62, 20);
            this.textBoxCountCola.TabIndex = 22;
            this.textBoxCountCola.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxCountCola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxPriceCola
            // 
            this.textBoxPriceCola.Enabled = false;
            this.textBoxPriceCola.Location = new System.Drawing.Point(77, 110);
            this.textBoxPriceCola.Name = "textBoxPriceCola";
            this.textBoxPriceCola.ReadOnly = true;
            this.textBoxPriceCola.Size = new System.Drawing.Size(60, 20);
            this.textBoxPriceCola.TabIndex = 21;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 113);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(51, 17);
            this.checkBox4.TabIndex = 20;
            this.checkBox4.Text = "Кола";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // textBoxCountFry
            // 
            this.textBoxCountFry.Enabled = false;
            this.textBoxCountFry.Location = new System.Drawing.Point(150, 84);
            this.textBoxCountFry.Name = "textBoxCountFry";
            this.textBoxCountFry.Size = new System.Drawing.Size(62, 20);
            this.textBoxCountFry.TabIndex = 19;
            this.textBoxCountFry.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxCountFry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxPriceFry
            // 
            this.textBoxPriceFry.Enabled = false;
            this.textBoxPriceFry.Location = new System.Drawing.Point(77, 84);
            this.textBoxPriceFry.Name = "textBoxPriceFry";
            this.textBoxPriceFry.ReadOnly = true;
            this.textBoxPriceFry.Size = new System.Drawing.Size(60, 20);
            this.textBoxPriceFry.TabIndex = 18;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 87);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(49, 17);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Фри";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBoxCountBurger
            // 
            this.textBoxCountBurger.Enabled = false;
            this.textBoxCountBurger.Location = new System.Drawing.Point(150, 58);
            this.textBoxCountBurger.Name = "textBoxCountBurger";
            this.textBoxCountBurger.Size = new System.Drawing.Size(62, 20);
            this.textBoxCountBurger.TabIndex = 16;
            this.textBoxCountBurger.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxCountBurger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxPriceBurger
            // 
            this.textBoxPriceBurger.Enabled = false;
            this.textBoxPriceBurger.Location = new System.Drawing.Point(77, 58);
            this.textBoxPriceBurger.Name = "textBoxPriceBurger";
            this.textBoxPriceBurger.ReadOnly = true;
            this.textBoxPriceBurger.Size = new System.Drawing.Size(60, 20);
            this.textBoxPriceBurger.TabIndex = 15;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 61);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Бургер";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBoxCountHotDog
            // 
            this.textBoxCountHotDog.Enabled = false;
            this.textBoxCountHotDog.Location = new System.Drawing.Point(150, 32);
            this.textBoxCountHotDog.Name = "textBoxCountHotDog";
            this.textBoxCountHotDog.Size = new System.Drawing.Size(62, 20);
            this.textBoxCountHotDog.TabIndex = 13;
            this.textBoxCountHotDog.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxCountHotDog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxPriceHotDog
            // 
            this.textBoxPriceHotDog.Enabled = false;
            this.textBoxPriceHotDog.Location = new System.Drawing.Point(77, 32);
            this.textBoxPriceHotDog.Name = "textBoxPriceHotDog";
            this.textBoxPriceHotDog.ReadOnly = true;
            this.textBoxPriceHotDog.Size = new System.Drawing.Size(60, 20);
            this.textBoxPriceHotDog.TabIndex = 12;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(150, 12);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(62, 13);
            this.textBox12.TabIndex = 11;
            this.textBox12.Text = "Количество";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(91, 12);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(35, 13);
            this.textBox11.TabIndex = 10;
            this.textBox11.Text = "Цена";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Хот-дог";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxPayableToCafe);
            this.groupBox5.Controls.Add(this.textBox14);
            this.groupBox5.Location = new System.Drawing.Point(7, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(187, 85);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "К оплате";
            // 
            // textBoxPayableToCafe
            // 
            this.textBoxPayableToCafe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPayableToCafe.Enabled = false;
            this.textBoxPayableToCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPayableToCafe.Location = new System.Drawing.Point(91, 34);
            this.textBoxPayableToCafe.Name = "textBoxPayableToCafe";
            this.textBoxPayableToCafe.ReadOnly = true;
            this.textBoxPayableToCafe.Size = new System.Drawing.Size(67, 42);
            this.textBoxPayableToCafe.TabIndex = 13;
            this.textBoxPayableToCafe.Text = "0";
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Location = new System.Drawing.Point(164, 60);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(21, 13);
            this.textBox14.TabIndex = 12;
            this.textBox14.Text = "грн";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(244, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.resetToolStripMenuItem.Text = "Сброс";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // CafeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CafeForm";
            this.Text = "BestOil";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCountCola;
        private System.Windows.Forms.TextBox textBoxPriceCola;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBoxCountFry;
        private System.Windows.Forms.TextBox textBoxPriceFry;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBoxCountBurger;
        private System.Windows.Forms.TextBox textBoxPriceBurger;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBoxCountHotDog;
        private System.Windows.Forms.TextBox textBoxPriceHotDog;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxPayableToCafe;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}