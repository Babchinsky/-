namespace TicTacToe
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CalculateButtonClick;
            // 
            // button2
            // 
            button2.Location = new Point(118, 12);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CalculateButtonClick;
            // 
            // button3
            // 
            button3.Location = new Point(224, 12);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 2;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CalculateButtonClick;
            // 
            // button4
            // 
            button4.Location = new Point(12, 118);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 3;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += CalculateButtonClick;
            // 
            // button5
            // 
            button5.Location = new Point(118, 118);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 4;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += CalculateButtonClick;
            // 
            // button6
            // 
            button6.Location = new Point(224, 118);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 5;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += CalculateButtonClick;
            // 
            // button7
            // 
            button7.Location = new Point(12, 224);
            button7.Name = "button7";
            button7.Size = new Size(100, 100);
            button7.TabIndex = 8;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += CalculateButtonClick;
            // 
            // button8
            // 
            button8.Location = new Point(118, 224);
            button8.Name = "button8";
            button8.Size = new Size(100, 100);
            button8.TabIndex = 7;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += CalculateButtonClick;
            // 
            // button9
            // 
            button9.Location = new Point(224, 224);
            button9.Name = "button9";
            button9.Size = new Size(100, 100);
            button9.TabIndex = 6;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += CalculateButtonClick;
            // 
            // button10
            // 
            button10.Location = new Point(358, 289);
            button10.Name = "button10";
            button10.Size = new Size(112, 34);
            button10.TabIndex = 9;
            button10.Text = "Restart";
            button10.UseVisualStyleBackColor = true;
            button10.Click += RestartButtonClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(349, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(138, 29);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Первый ход";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(349, 49);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(115, 29);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Сложный";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 335);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "TicTacToe";
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
        private Button button10;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}