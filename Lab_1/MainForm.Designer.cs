﻿namespace Lab_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.t_Tree = new System.Windows.Forms.TreeView();
            this.l_Explorer = new System.Windows.Forms.Label();
            this.d_Table = new System.Windows.Forms.DataGridView();
            this.l_Element = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.BackColor = System.Drawing.Color.White;
            this.menuStripMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStripMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 40);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.connectToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.connectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("connectToolStripMenuItem.Image")));
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(88, 36);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(60, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.t_Tree);
            this.splitContainer1.Panel1.Controls.Add(this.l_Explorer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.d_Table);
            this.splitContainer1.Panel2.Controls.Add(this.l_Element);
            this.splitContainer1.Size = new System.Drawing.Size(784, 564);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 2;
            // 
            // t_Tree
            // 
            this.t_Tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.t_Tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_Tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_Tree.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_Tree.Indent = 20;
            this.t_Tree.Location = new System.Drawing.Point(0, 25);
            this.t_Tree.Name = "t_Tree";
            this.t_Tree.Size = new System.Drawing.Size(257, 535);
            this.t_Tree.TabIndex = 1;
            this.t_Tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.t_Tree_AfterSelect);
            // 
            // l_Explorer
            // 
            this.l_Explorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.l_Explorer.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_Explorer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Explorer.ForeColor = System.Drawing.Color.White;
            this.l_Explorer.Location = new System.Drawing.Point(0, 0);
            this.l_Explorer.Name = "l_Explorer";
            this.l_Explorer.Size = new System.Drawing.Size(257, 25);
            this.l_Explorer.TabIndex = 0;
            this.l_Explorer.Text = "Explorer";
            this.l_Explorer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_Table
            // 
            this.d_Table.AllowUserToAddRows = false;
            this.d_Table.AllowUserToDeleteRows = false;
            this.d_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.d_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.d_Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.d_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.d_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.d_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.d_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.d_Table.DefaultCellStyle = dataGridViewCellStyle2;
            this.d_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d_Table.EnableHeadersVisualStyles = false;
            this.d_Table.Location = new System.Drawing.Point(0, 25);
            this.d_Table.Name = "d_Table";
            this.d_Table.ReadOnly = true;
            this.d_Table.RowHeadersVisible = false;
            this.d_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.d_Table.Size = new System.Drawing.Size(515, 535);
            this.d_Table.TabIndex = 2;
            // 
            // l_Element
            // 
            this.l_Element.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.l_Element.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_Element.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Element.ForeColor = System.Drawing.Color.White;
            this.l_Element.Location = new System.Drawing.Point(0, 0);
            this.l_Element.Name = "l_Element";
            this.l_Element.Size = new System.Drawing.Size(515, 25);
            this.l_Element.TabIndex = 1;
            this.l_Element.Text = "Element";
            this.l_Element.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 604);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(800, 643);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База знаний";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.d_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView t_Tree;
        private System.Windows.Forms.Label l_Explorer;
        private System.Windows.Forms.DataGridView d_Table;
        private System.Windows.Forms.Label l_Element;
    }
}

