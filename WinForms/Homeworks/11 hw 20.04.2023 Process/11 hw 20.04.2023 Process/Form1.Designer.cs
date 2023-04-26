namespace _11_hw_20._04._2023_Process
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonEndTask = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(632, 428);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonEndTask
            // 
            this.buttonEndTask.Location = new System.Drawing.Point(713, 428);
            this.buttonEndTask.Name = "buttonEndTask";
            this.buttonEndTask.Size = new System.Drawing.Size(75, 23);
            this.buttonEndTask.TabIndex = 3;
            this.buttonEndTask.Text = "End Task";
            this.buttonEndTask.UseVisualStyleBackColor = true;
            this.buttonEndTask.Click += new System.EventHandler(this.buttonEndTask_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPID});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 395);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 150;
            // 
            // columnPID
            // 
            this.columnPID.Text = "PID";
            this.columnPID.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProcessToolStripMenuItem});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sToolStripMenuItem.Text = "File";
            // 
            // newProcessToolStripMenuItem
            // 
            this.newProcessToolStripMenuItem.Name = "newProcessToolStripMenuItem";
            this.newProcessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newProcessToolStripMenuItem.Text = "Run New Task";
            this.newProcessToolStripMenuItem.Click += new System.EventHandler(this.newProcessToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonEndTask);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonEndTask;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProcessToolStripMenuItem;
    }
}

