namespace _11_hw_20._04._2023_Process
{
    partial class StartProcess
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
            this.textBoxOpen = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOpen
            // 
            this.textBoxOpen.Location = new System.Drawing.Point(50, 9);
            this.textBoxOpen.Name = "textBoxOpen";
            this.textBoxOpen.Size = new System.Drawing.Size(255, 20);
            this.textBoxOpen.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(32, 13);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Open:";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(230, 37);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // StartProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 72);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxOpen);
            this.Name = "StartProcess";
            this.Text = "Run New Process";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOpen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonRun;
    }
}