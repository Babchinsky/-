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
            Player_goes_first = new CheckBox();
            Cross = new RadioButton();
            Zero = new RadioButton();
            Player_plays_with = new GroupBox();
            Simple = new RadioButton();
            Medium = new RadioButton();
            Hard = new RadioButton();
            Difficulty_level = new GroupBox();
            tabControl1 = new TabControl();
            tabSettings = new TabPage();
            button7 = new Button();
            button8 = new Button();
            button6 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            Start_new_game = new Button();
            button2 = new Button();
            button0 = new Button();
            button1 = new Button();
            tabGame = new TabPage();
            PlayersMove = new RadioButton();
            ComputersMove = new RadioButton();
            groupBox1 = new GroupBox();
            Player_plays_with.SuspendLayout();
            Difficulty_level.SuspendLayout();
            tabControl1.SuspendLayout();
            tabSettings.SuspendLayout();
            tabGame.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Player_goes_first
            // 
            Player_goes_first.AutoSize = true;
            Player_goes_first.Checked = true;
            Player_goes_first.CheckState = CheckState.Checked;
            Player_goes_first.Location = new System.Drawing.Point(64, 315);
            Player_goes_first.Margin = new Padding(4, 5, 4, 5);
            Player_goes_first.Name = "Player_goes_first";
            Player_goes_first.Size = new Size(211, 29);
            Player_goes_first.TabIndex = 9;
            Player_goes_first.Text = "Игрок ходит первым";
            Player_goes_first.UseVisualStyleBackColor = true;
            Player_goes_first.CheckedChanged += CheckBoxClick;
            // 
            // Cross
            // 
            Cross.AutoSize = true;
            Cross.Checked = true;
            Cross.Location = new System.Drawing.Point(30, 35);
            Cross.Margin = new Padding(4, 5, 4, 5);
            Cross.Name = "Cross";
            Cross.Size = new Size(125, 29);
            Cross.TabIndex = 10;
            Cross.TabStop = true;
            Cross.Text = "Крестиком";
            Cross.UseVisualStyleBackColor = true;
            Cross.Click += PlayerSignRadioButtonClick;
            // 
            // Zero
            // 
            Zero.AutoSize = true;
            Zero.Location = new System.Drawing.Point(30, 76);
            Zero.Margin = new Padding(4, 5, 4, 5);
            Zero.Name = "Zero";
            Zero.Size = new Size(113, 29);
            Zero.TabIndex = 11;
            Zero.TabStop = true;
            Zero.Text = "Ноликом";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += PlayerSignRadioButtonClick;
            // 
            // Player_plays_with
            // 
            Player_plays_with.Controls.Add(Zero);
            Player_plays_with.Controls.Add(Cross);
            Player_plays_with.Location = new System.Drawing.Point(34, 381);
            Player_plays_with.Margin = new Padding(4, 5, 4, 5);
            Player_plays_with.Name = "Player_plays_with";
            Player_plays_with.Padding = new Padding(4, 5, 4, 5);
            Player_plays_with.Size = new Size(244, 116);
            Player_plays_with.TabIndex = 12;
            Player_plays_with.TabStop = false;
            Player_plays_with.Text = "Игрок управляет";
            // 
            // Simple
            // 
            Simple.AutoSize = true;
            Simple.Location = new System.Drawing.Point(36, 56);
            Simple.Margin = new Padding(4, 5, 4, 5);
            Simple.Name = "Simple";
            Simple.Size = new Size(92, 29);
            Simple.TabIndex = 14;
            Simple.Text = "Лёгкая";
            Simple.UseVisualStyleBackColor = true;
            Simple.Click += DifficultyRadioButtonClick;
            // 
            // Medium
            // 
            Medium.AutoSize = true;
            Medium.Checked = true;
            Medium.Location = new System.Drawing.Point(36, 115);
            Medium.Margin = new Padding(4, 5, 4, 5);
            Medium.Name = "Medium";
            Medium.Size = new Size(106, 29);
            Medium.TabIndex = 14;
            Medium.TabStop = true;
            Medium.Text = "Средняя";
            Medium.UseVisualStyleBackColor = true;
            Medium.Click += DifficultyRadioButtonClick;
            // 
            // Hard
            // 
            Hard.AutoSize = true;
            Hard.Location = new System.Drawing.Point(36, 171);
            Hard.Margin = new Padding(4, 5, 4, 5);
            Hard.Name = "Hard";
            Hard.Size = new Size(104, 29);
            Hard.TabIndex = 14;
            Hard.Text = "Тяжёлая";
            Hard.UseVisualStyleBackColor = true;
            Hard.Click += DifficultyRadioButtonClick;
            // 
            // Difficulty_level
            // 
            Difficulty_level.Controls.Add(Hard);
            Difficulty_level.Controls.Add(Medium);
            Difficulty_level.Controls.Add(Simple);
            Difficulty_level.Location = new System.Drawing.Point(28, 36);
            Difficulty_level.Margin = new Padding(4, 5, 4, 5);
            Difficulty_level.Name = "Difficulty_level";
            Difficulty_level.Padding = new Padding(4, 5, 4, 5);
            Difficulty_level.Size = new Size(278, 229);
            Difficulty_level.TabIndex = 15;
            Difficulty_level.TabStop = false;
            Difficulty_level.Text = "Сложность";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabGame);
            tabControl1.Controls.Add(tabSettings);
            tabControl1.Location = new System.Drawing.Point(5, 15);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(287, 571);
            tabControl1.TabIndex = 19;
            // 
            // tabSettings
            // 
            tabSettings.Controls.Add(Player_goes_first);
            tabSettings.Controls.Add(Difficulty_level);
            tabSettings.Controls.Add(Player_plays_with);
            tabSettings.Location = new System.Drawing.Point(4, 34);
            tabSettings.Margin = new Padding(4);
            tabSettings.Name = "tabSettings";
            tabSettings.Padding = new Padding(4);
            tabSettings.Size = new Size(265, 533);
            tabSettings.TabIndex = 1;
            tabSettings.Text = "Настройки";
            tabSettings.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(105, 324);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(76, 94);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            button7.Click += Playground_Click;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(189, 324);
            button8.Margin = new Padding(4, 5, 4, 5);
            button8.Name = "button8";
            button8.Size = new Size(76, 94);
            button8.TabIndex = 6;
            button8.UseVisualStyleBackColor = true;
            button8.Click += Playground_Click;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(20, 324);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(76, 94);
            button6.TabIndex = 8;
            button6.UseVisualStyleBackColor = true;
            button6.Click += Playground_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(20, 220);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(76, 94);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Playground_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(105, 220);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(76, 94);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += Playground_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(189, 220);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(76, 94);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = true;
            button5.Click += Playground_Click;
            // 
            // Start_new_game
            // 
            Start_new_game.Location = new System.Drawing.Point(20, 428);
            Start_new_game.Margin = new Padding(4, 5, 4, 5);
            Start_new_game.Name = "Start_new_game";
            Start_new_game.Size = new Size(245, 94);
            Start_new_game.TabIndex = 13;
            Start_new_game.Text = "Новая игра";
            Start_new_game.UseVisualStyleBackColor = true;
            Start_new_game.Click += GameStartClick;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(189, 116);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(76, 94);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Playground_Click;
            // 
            // button0
            // 
            button0.Location = new System.Drawing.Point(20, 116);
            button0.Margin = new Padding(4, 5, 4, 5);
            button0.Name = "button0";
            button0.Size = new Size(76, 94);
            button0.TabIndex = 0;
            button0.UseVisualStyleBackColor = true;
            button0.Click += Playground_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(105, 116);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(76, 94);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Playground_Click;
            // 
            // tabGame
            // 
            tabGame.Controls.Add(button1);
            tabGame.Controls.Add(groupBox1);
            tabGame.Controls.Add(button0);
            tabGame.Controls.Add(button2);
            tabGame.Controls.Add(Start_new_game);
            tabGame.Controls.Add(button5);
            tabGame.Controls.Add(button4);
            tabGame.Controls.Add(button3);
            tabGame.Controls.Add(button6);
            tabGame.Controls.Add(button8);
            tabGame.Controls.Add(button7);
            tabGame.Location = new System.Drawing.Point(4, 34);
            tabGame.Margin = new Padding(4);
            tabGame.Name = "tabGame";
            tabGame.Padding = new Padding(4);
            tabGame.Size = new Size(279, 533);
            tabGame.TabIndex = 0;
            tabGame.Text = "Игра";
            tabGame.UseVisualStyleBackColor = true;
            // 
            // PlayersMove
            // 
            PlayersMove.AutoSize = true;
            PlayersMove.Enabled = false;
            PlayersMove.Location = new System.Drawing.Point(25, 35);
            PlayersMove.Margin = new Padding(4);
            PlayersMove.Name = "PlayersMove";
            PlayersMove.Size = new Size(88, 29);
            PlayersMove.TabIndex = 16;
            PlayersMove.TabStop = true;
            PlayersMove.Text = "Игрок";
            PlayersMove.UseVisualStyleBackColor = true;
            // 
            // ComputersMove
            // 
            ComputersMove.AutoSize = true;
            ComputersMove.Enabled = false;
            ComputersMove.Location = new System.Drawing.Point(121, 35);
            ComputersMove.Margin = new Padding(4);
            ComputersMove.Name = "ComputersMove";
            ComputersMove.Size = new Size(60, 29);
            ComputersMove.TabIndex = 17;
            ComputersMove.TabStop = true;
            ComputersMove.Text = "ПК";
            ComputersMove.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ComputersMove);
            groupBox1.Controls.Add(PlayersMove);
            groupBox1.Location = new System.Drawing.Point(15, 10);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(250, 82);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Первый ход";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 585);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Крестики-нолики";
            Player_plays_with.ResumeLayout(false);
            Player_plays_with.PerformLayout();
            Difficulty_level.ResumeLayout(false);
            Difficulty_level.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabSettings.ResumeLayout(false);
            tabSettings.PerformLayout();
            tabGame.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox Player_goes_first;
        private RadioButton Cross;
        private RadioButton Zero;
        private GroupBox Player_plays_with;
        private RadioButton Simple;
        private RadioButton Medium;
        private RadioButton Hard;
        private GroupBox Difficulty_level;
        private TabControl tabControl1;
        private TabPage tabSettings;
        private TabPage tabGame;
        private Button button1;
        private Button button0;
        private Button button2;
        private Button Start_new_game;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button8;
        private Button button7;
        private GroupBox groupBox1;
        private RadioButton ComputersMove;
        private RadioButton PlayersMove;
    }
}