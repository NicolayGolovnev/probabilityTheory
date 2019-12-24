namespace Zaychik
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.групированнаяРядToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.групированныйРядДляYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корреляционнаяТаблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTable = new System.Windows.Forms.DataGridView();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.групированнаяРядToolStripMenuItem,
            this.групированныйРядДляYToolStripMenuItem,
            this.корреляционнаяТаблицаToolStripMenuItem,
            this.открытьФайлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // групированнаяРядToolStripMenuItem
            // 
            this.групированнаяРядToolStripMenuItem.Name = "групированнаяРядToolStripMenuItem";
            this.групированнаяРядToolStripMenuItem.Size = new System.Drawing.Size(244, 29);
            this.групированнаяРядToolStripMenuItem.Text = "Групированный ряд для X";
            this.групированнаяРядToolStripMenuItem.Click += new System.EventHandler(this.групированнаяРядToolStripMenuItem_Click);
            // 
            // групированныйРядДляYToolStripMenuItem
            // 
            this.групированныйРядДляYToolStripMenuItem.Name = "групированныйРядДляYToolStripMenuItem";
            this.групированныйРядДляYToolStripMenuItem.Size = new System.Drawing.Size(243, 29);
            this.групированныйРядДляYToolStripMenuItem.Text = "Групированный ряд для Y";
            this.групированныйРядДляYToolStripMenuItem.Click += new System.EventHandler(this.групированныйРядДляYToolStripMenuItem_Click);
            // 
            // корреляционнаяТаблицаToolStripMenuItem
            // 
            this.корреляционнаяТаблицаToolStripMenuItem.Name = "корреляционнаяТаблицаToolStripMenuItem";
            this.корреляционнаяТаблицаToolStripMenuItem.Size = new System.Drawing.Size(238, 29);
            this.корреляционнаяТаблицаToolStripMenuItem.Text = "Корреляционная таблица";
            this.корреляционнаяТаблицаToolStripMenuItem.Click += new System.EventHandler(this.корреляционнаяТаблицаToolStripMenuItem_Click);
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // mainTable
            // 
            this.mainTable.AllowUserToAddRows = false;
            this.mainTable.AllowUserToDeleteRows = false;
            this.mainTable.AllowUserToResizeColumns = false;
            this.mainTable.AllowUserToResizeRows = false;
            this.mainTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X1,
            this.Y1,
            this.X2,
            this.Y2,
            this.X3,
            this.Y3,
            this.X4,
            this.Y4,
            this.X5,
            this.Y5});
            this.mainTable.Location = new System.Drawing.Point(22, 46);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowHeadersVisible = false;
            this.mainTable.RowHeadersWidth = 62;
            this.mainTable.RowTemplate.Height = 28;
            this.mainTable.RowTemplate.ReadOnly = true;
            this.mainTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mainTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mainTable.Size = new System.Drawing.Size(778, 321);
            this.mainTable.TabIndex = 2;
            // 
            // X1
            // 
            this.X1.HeaderText = "xᵢ";
            this.X1.MinimumWidth = 8;
            this.X1.Name = "X1";
            // 
            // Y1
            // 
            this.Y1.HeaderText = "yᵢ";
            this.Y1.MinimumWidth = 8;
            this.Y1.Name = "Y1";
            // 
            // X2
            // 
            this.X2.HeaderText = "xᵢ";
            this.X2.MinimumWidth = 8;
            this.X2.Name = "X2";
            // 
            // Y2
            // 
            this.Y2.HeaderText = "yᵢ";
            this.Y2.MinimumWidth = 8;
            this.Y2.Name = "Y2";
            // 
            // X3
            // 
            this.X3.HeaderText = "xᵢ";
            this.X3.MinimumWidth = 8;
            this.X3.Name = "X3";
            // 
            // Y3
            // 
            this.Y3.HeaderText = "yᵢ";
            this.Y3.MinimumWidth = 8;
            this.Y3.Name = "Y3";
            // 
            // X4
            // 
            this.X4.HeaderText = "xᵢ";
            this.X4.MinimumWidth = 8;
            this.X4.Name = "X4";
            // 
            // Y4
            // 
            this.Y4.HeaderText = "yᵢ";
            this.Y4.MinimumWidth = 8;
            this.Y4.Name = "Y4";
            // 
            // X5
            // 
            this.X5.HeaderText = "xᵢ";
            this.X5.MinimumWidth = 8;
            this.X5.Name = "X5";
            // 
            // Y5
            // 
            this.Y5.HeaderText = "yᵢ";
            this.Y5.MinimumWidth = 8;
            this.Y5.Name = "Y5";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 492);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem групированнаяРядToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem групированныйРядДляYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem корреляционнаяТаблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.DataGridView mainTable;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y2;
        private System.Windows.Forms.DataGridViewTextBoxColumn X3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y3;
        private System.Windows.Forms.DataGridViewTextBoxColumn X4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y4;
        private System.Windows.Forms.DataGridViewTextBoxColumn X5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y5;
    }
}

