namespace Tic_Tac_Toe_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            label2 = new Label();
            button10 = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(10, 54);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += PlayerClickButton;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(117, 54);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(223, 54);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(11, 160);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = false;
            button4.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(117, 160);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 128, 0);
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(223, 160);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = false;
            button6.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 128, 0);
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(11, 266);
            button7.Name = "button7";
            button7.Size = new Size(100, 100);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = false;
            button7.Click += PlayerClickButton;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 128, 0);
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(117, 266);
            button8.Name = "button8";
            button8.Size = new Size(100, 100);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 128, 0);
            button9.Cursor = Cursors.Hand;
            button9.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(223, 266);
            button9.Name = "button9";
            button9.Size = new Size(100, 100);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = false;
            button9.Click += PlayerClickButton;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 9;
            label1.Text = "Player Wins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(223, 9);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 10;
            label2.Text = "CPU Wins:";
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(0, 192, 192);
            button10.Location = new Point(131, 372);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 11;
            button10.Text = "Restart";
            button10.UseVisualStyleBackColor = false;
            button10.Click += RestartGame;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            CPUTimer.Tick += CPUMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 398);
            Controls.Add(button10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Label label2;
        private Button button10;
        private System.Windows.Forms.Timer CPUTimer;
    }
}