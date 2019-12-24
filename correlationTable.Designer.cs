namespace Zaychik
{
    partial class correlationTable
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
            this.table = new System.Windows.Forms.DataGridView();
            this.interX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interY2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interY3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interY4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interY5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interY6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interY7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.interX,
            this.interY1,
            this.interY2,
            this.interY3,
            this.interY4,
            this.interY5,
            this.interY6,
            this.interY7,
            this.countX});
            this.table.Dock = System.Windows.Forms.DockStyle.Top;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 62;
            this.table.RowTemplate.Height = 28;
            this.table.Size = new System.Drawing.Size(922, 203);
            this.table.TabIndex = 0;
            // 
            // interX
            // 
            this.interX.HeaderText = "X \\ Y";
            this.interX.MinimumWidth = 8;
            this.interX.Name = "interX";
            // 
            // interY1
            // 
            this.interY1.HeaderText = "";
            this.interY1.MinimumWidth = 8;
            this.interY1.Name = "interY1";
            // 
            // interY2
            // 
            this.interY2.HeaderText = "";
            this.interY2.MinimumWidth = 8;
            this.interY2.Name = "interY2";
            // 
            // interY3
            // 
            this.interY3.HeaderText = "";
            this.interY3.MinimumWidth = 8;
            this.interY3.Name = "interY3";
            // 
            // interY4
            // 
            this.interY4.HeaderText = "";
            this.interY4.MinimumWidth = 8;
            this.interY4.Name = "interY4";
            // 
            // interY5
            // 
            this.interY5.HeaderText = "";
            this.interY5.MinimumWidth = 8;
            this.interY5.Name = "interY5";
            // 
            // interY6
            // 
            this.interY6.HeaderText = "";
            this.interY6.MinimumWidth = 8;
            this.interY6.Name = "interY6";
            // 
            // interY7
            // 
            this.interY7.HeaderText = "";
            this.interY7.MinimumWidth = 8;
            this.interY7.Name = "interY7";
            // 
            // countX
            // 
            this.countX.HeaderText = "nᵢ";
            this.countX.MinimumWidth = 8;
            this.countX.Name = "countX";
            // 
            // correlationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 367);
            this.Controls.Add(this.table);
            this.Name = "correlationTable";
            this.Text = "correlationTable";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn interX;
        private System.Windows.Forms.DataGridViewTextBoxColumn interY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn interY2;
        private System.Windows.Forms.DataGridViewTextBoxColumn interY3;
        private System.Windows.Forms.DataGridViewTextBoxColumn interY4;
        private System.Windows.Forms.DataGridViewTextBoxColumn interY5;
        private System.Windows.Forms.DataGridViewTextBoxColumn interY6;
        private System.Windows.Forms.DataGridViewTextBoxColumn interY7;
        private System.Windows.Forms.DataGridViewTextBoxColumn countX;
    }
}