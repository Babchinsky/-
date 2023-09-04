
namespace WhoWantToBeMillioner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторскийРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.TextBox();
            this.Answer_A = new System.Windows.Forms.Button();
            this.Answer_B = new System.Windows.Forms.Button();
            this.Answer_C = new System.Windows.Forms.Button();
            this.Answer_D = new System.Windows.Forms.Button();
            this.Подсказки = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RightAnswer = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Correct = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Подсказки.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.Color.Yellow;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Items.AddRange(new object[] {
            "15- 1 000 000 ",
            "14 - 500 000",
            "13 - 250 000",
            "12 - 125 000",
            "11-  64 000 ",
            "10 - 32 000",
            "9 - 16 000 ",
            "8 - 8 000",
            "7 - 4 000",
            "6 - 2 000",
            "5 - 1 000",
            "4 - 500",
            "3-  300",
            "2-  200",
            "1 - 100"});
            this.listBox1.Location = new System.Drawing.Point(627, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 469);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-181, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(800, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.Enabled = false;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 59);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.Enabled = false;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(78, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 59);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlText;
            this.button3.Enabled = false;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(157, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 59);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.администраторскийРежимToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // NewGameToolStripMenuItem
            // 
            this.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            this.NewGameToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.NewGameToolStripMenuItem.Text = "Новая Игра";
            this.NewGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // администраторскийРежимToolStripMenuItem
            // 
            this.администраторскийРежимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВопросToolStripMenuItem,
            this.удToolStripMenuItem,
            this.редактироватьВопросToolStripMenuItem});
            this.администраторскийРежимToolStripMenuItem.Name = "администраторскийРежимToolStripMenuItem";
            this.администраторскийРежимToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.администраторскийРежимToolStripMenuItem.Text = "Администраторский Режим";
            // 
            // добавитьВопросToolStripMenuItem
            // 
            this.добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            this.добавитьВопросToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.добавитьВопросToolStripMenuItem.Text = "Добавить Вопрос";
            this.добавитьВопросToolStripMenuItem.Click += new System.EventHandler(this.добавитьВопросToolStripMenuItem_Click);
            // 
            // удToolStripMenuItem
            // 
            this.удToolStripMenuItem.Name = "удToolStripMenuItem";
            this.удToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.удToolStripMenuItem.Text = "Удалить Вопрос";
            this.удToolStripMenuItem.Click += new System.EventHandler(this.удToolStripMenuItem_Click);
            // 
            // редактироватьВопросToolStripMenuItem
            // 
            this.редактироватьВопросToolStripMenuItem.Name = "редактироватьВопросToolStripMenuItem";
            this.редактироватьВопросToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.редактироватьВопросToolStripMenuItem.Text = "Редактировать Вопрос";
            this.редактироватьВопросToolStripMenuItem.Click += new System.EventHandler(this.редактироватьВопросToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlText;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(12, 35);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(73, 51);
            this.button4.TabIndex = 5;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlText;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(91, 35);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(73, 51);
            this.button5.TabIndex = 5;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlText;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.Yellow;
            this.button6.Location = new System.Drawing.Point(170, 35);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(96, 51);
            this.button6.TabIndex = 5;
            this.button6.Text = "Стоп";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Question
            // 
            this.Question.BackColor = System.Drawing.SystemColors.ControlText;
            this.Question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.ForeColor = System.Drawing.Color.Yellow;
            this.Question.Location = new System.Drawing.Point(57, 334);
            this.Question.Multiline = true;
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(458, 88);
            this.Question.TabIndex = 6;
            // 
            // Answer_A
            // 
            this.Answer_A.BackColor = System.Drawing.SystemColors.ControlText;
            this.Answer_A.Enabled = false;
            this.Answer_A.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Answer_A.ForeColor = System.Drawing.Color.Yellow;
            this.Answer_A.Location = new System.Drawing.Point(57, 428);
            this.Answer_A.Name = "Answer_A";
            this.Answer_A.Size = new System.Drawing.Size(178, 54);
            this.Answer_A.TabIndex = 7;
            this.Answer_A.UseVisualStyleBackColor = false;
            this.Answer_A.Click += new System.EventHandler(this.Answer_A_Click);
            // 
            // Answer_B
            // 
            this.Answer_B.BackColor = System.Drawing.SystemColors.ControlText;
            this.Answer_B.Enabled = false;
            this.Answer_B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Answer_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer_B.ForeColor = System.Drawing.Color.Yellow;
            this.Answer_B.Location = new System.Drawing.Point(337, 428);
            this.Answer_B.Name = "Answer_B";
            this.Answer_B.Size = new System.Drawing.Size(178, 54);
            this.Answer_B.TabIndex = 7;
            this.Answer_B.UseVisualStyleBackColor = false;
            this.Answer_B.Click += new System.EventHandler(this.Answer_B_Click);
            // 
            // Answer_C
            // 
            this.Answer_C.BackColor = System.Drawing.SystemColors.ControlText;
            this.Answer_C.Enabled = false;
            this.Answer_C.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Answer_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer_C.ForeColor = System.Drawing.Color.Yellow;
            this.Answer_C.Location = new System.Drawing.Point(57, 505);
            this.Answer_C.Name = "Answer_C";
            this.Answer_C.Size = new System.Drawing.Size(178, 54);
            this.Answer_C.TabIndex = 7;
            this.Answer_C.UseVisualStyleBackColor = false;
            this.Answer_C.Click += new System.EventHandler(this.Answer_C_Click);
            // 
            // Answer_D
            // 
            this.Answer_D.BackColor = System.Drawing.SystemColors.ControlText;
            this.Answer_D.Enabled = false;
            this.Answer_D.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Answer_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer_D.ForeColor = System.Drawing.Color.Yellow;
            this.Answer_D.Location = new System.Drawing.Point(337, 505);
            this.Answer_D.Name = "Answer_D";
            this.Answer_D.Size = new System.Drawing.Size(178, 54);
            this.Answer_D.TabIndex = 7;
            this.Answer_D.UseVisualStyleBackColor = false;
            this.Answer_D.Click += new System.EventHandler(this.Answer_D_Click);
            // 
            // Подсказки
            // 
            this.Подсказки.Controls.Add(this.button3);
            this.Подсказки.Controls.Add(this.button2);
            this.Подсказки.Controls.Add(this.button1);
            this.Подсказки.ForeColor = System.Drawing.Color.Yellow;
            this.Подсказки.Location = new System.Drawing.Point(627, 27);
            this.Подсказки.Name = "Подсказки";
            this.Подсказки.Size = new System.Drawing.Size(234, 74);
            this.Подсказки.TabIndex = 8;
            this.Подсказки.TabStop = false;
            this.Подсказки.Text = "Подсказки ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 109);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // RightAnswer
            // 
            this.RightAnswer.BackColor = System.Drawing.Color.CadetBlue;
            this.RightAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RightAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightAnswer.ForeColor = System.Drawing.Color.Yellow;
            this.RightAnswer.Location = new System.Drawing.Point(153, 140);
            this.RightAnswer.Multiline = true;
            this.RightAnswer.Name = "RightAnswer";
            this.RightAnswer.Size = new System.Drawing.Size(259, 104);
            this.RightAnswer.TabIndex = 10;
            this.RightAnswer.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(485, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 99);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // Correct
            // 
            this.Correct.BackColor = System.Drawing.Color.CadetBlue;
            this.Correct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Correct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Correct.ForeColor = System.Drawing.Color.Yellow;
            this.Correct.Location = new System.Drawing.Point(351, 294);
            this.Correct.Multiline = true;
            this.Correct.Name = "Correct";
            this.Correct.Size = new System.Drawing.Size(128, 34);
            this.Correct.TabIndex = 10;
            this.Correct.Text = "Правильно!";
            this.Correct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Correct.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Blue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.progressBar4);
            this.groupBox1.Controls.Add(this.progressBar3);
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(435, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 185);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Помощь зала";
            this.groupBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "D:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A:";
            // 
            // progressBar4
            // 
            this.progressBar4.BackColor = System.Drawing.Color.Red;
            this.progressBar4.Location = new System.Drawing.Point(50, 135);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(122, 16);
            this.progressBar4.TabIndex = 0;
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.Color.Red;
            this.progressBar3.Location = new System.Drawing.Point(50, 103);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(122, 16);
            this.progressBar3.TabIndex = 0;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Red;
            this.progressBar2.Location = new System.Drawing.Point(50, 68);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(122, 16);
            this.progressBar2.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Red;
            this.progressBar1.ForeColor = System.Drawing.Color.Blue;
            this.progressBar1.Location = new System.Drawing.Point(50, 37);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(122, 16);
            this.progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(871, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Correct);
            this.Controls.Add(this.RightAnswer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Подсказки);
            this.Controls.Add(this.Answer_D);
            this.Controls.Add(this.Answer_C);
            this.Controls.Add(this.Answer_B);
            this.Controls.Add(this.Answer_A);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Подсказки.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторскийРежимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.Button Answer_A;
        private System.Windows.Forms.Button Answer_B;
        private System.Windows.Forms.Button Answer_C;
        private System.Windows.Forms.Button Answer_D;
        private System.Windows.Forms.GroupBox Подсказки;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox RightAnswer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox Correct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьВопросToolStripMenuItem;
    }
}

