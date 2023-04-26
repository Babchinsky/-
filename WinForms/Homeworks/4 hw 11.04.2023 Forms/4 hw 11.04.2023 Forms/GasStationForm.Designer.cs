namespace _4_hw_11._04._2023_Forms
{
    partial class GasStationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBoxPayableToGas = new System.Windows.Forms.TextBox();
            this.textBoxGasMoney = new System.Windows.Forms.TextBox();
            this.textBoxFuelCount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBoxFuelPricePerL = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.textBoxGasMoney);
            this.groupBox1.Controls.Add(this.textBoxFuelCount);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxFuelPricePerL);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBoxPayableToGas);
            this.groupBox3.Location = new System.Drawing.Point(6, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 73);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "К оплате";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(181, 45);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(21, 13);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "грн";
            // 
            // textBoxPayableToGas
            // 
            this.textBoxPayableToGas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPayableToGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPayableToGas.Location = new System.Drawing.Point(64, 12);
            this.textBoxPayableToGas.Name = "textBoxPayableToGas";
            this.textBoxPayableToGas.ReadOnly = true;
            this.textBoxPayableToGas.Size = new System.Drawing.Size(100, 55);
            this.textBoxPayableToGas.TabIndex = 7;
            this.textBoxPayableToGas.Text = "0";
            // 
            // textBoxGasMoney
            // 
            this.textBoxGasMoney.Enabled = false;
            this.textBoxGasMoney.Location = new System.Drawing.Point(118, 138);
            this.textBoxGasMoney.Name = "textBoxGasMoney";
            this.textBoxGasMoney.Size = new System.Drawing.Size(95, 20);
            this.textBoxGasMoney.TabIndex = 6;
            this.textBoxGasMoney.TextChanged += new System.EventHandler(this.textBoxFuelCount_TextChanged);
            this.textBoxGasMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxFuelCount
            // 
            this.textBoxFuelCount.Location = new System.Drawing.Point(118, 112);
            this.textBoxFuelCount.Name = "textBoxFuelCount";
            this.textBoxFuelCount.Size = new System.Drawing.Size(95, 20);
            this.textBoxFuelCount.TabIndex = 5;
            this.textBoxFuelCount.TextChanged += new System.EventHandler(this.textBoxFuelCount_TextChanged);
            this.textBoxFuelCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(6, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 73);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Сумма";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Количество";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // textBoxFuelPricePerL
            // 
            this.textBoxFuelPricePerL.Location = new System.Drawing.Point(106, 54);
            this.textBoxFuelPricePerL.Name = "textBoxFuelPricePerL";
            this.textBoxFuelPricePerL.ReadOnly = true;
            this.textBoxFuelPricePerL.Size = new System.Drawing.Size(107, 20);
            this.textBoxFuelPricePerL.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(6, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Цена";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Топливо";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(244, 24);
            this.menuStrip1.TabIndex = 1;
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
            // GasStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 298);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GasStationForm";
            this.Text = "BestOil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBoxFuelPricePerL;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxGasMoney;
        private System.Windows.Forms.TextBox textBoxFuelCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBoxPayableToGas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}