namespace Zaychik
{
    partial class HipotesyX
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
            this.raspredX = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.raspredX)).BeginInit();
            this.SuspendLayout();
            // 
            // raspredX
            // 
            this.raspredX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raspredX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.inter,
            this.ni,
            this.Zi,
            this.Fi,
            this.pi,
            this.npi,
            this.res});
            this.raspredX.Location = new System.Drawing.Point(0, 0);
            this.raspredX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.raspredX.Name = "raspredX";
            this.raspredX.RowHeadersWidth = 51;
            this.raspredX.RowTemplate.Height = 24;
            this.raspredX.Size = new System.Drawing.Size(903, 236);
            this.raspredX.TabIndex = 0;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.MinimumWidth = 6;
            this.i.Name = "i";
            this.i.Width = 125;
            // 
            // inter
            // 
            this.inter.HeaderText = "interval";
            this.inter.MinimumWidth = 6;
            this.inter.Name = "inter";
            this.inter.Width = 125;
            // 
            // ni
            // 
            this.ni.HeaderText = "Ni";
            this.ni.MinimumWidth = 6;
            this.ni.Name = "ni";
            this.ni.Width = 125;
            // 
            // Zi
            // 
            this.Zi.HeaderText = "Zi";
            this.Zi.MinimumWidth = 6;
            this.Zi.Name = "Zi";
            this.Zi.Width = 125;
            // 
            // Fi
            // 
            this.Fi.HeaderText = "Фi";
            this.Fi.MinimumWidth = 6;
            this.Fi.Name = "Fi";
            this.Fi.Width = 125;
            // 
            // pi
            // 
            this.pi.HeaderText = "Pi";
            this.pi.MinimumWidth = 6;
            this.pi.Name = "pi";
            this.pi.Width = 125;
            // 
            // npi
            // 
            this.npi.HeaderText = "npi";
            this.npi.MinimumWidth = 6;
            this.npi.Name = "npi";
            this.npi.Width = 125;
            // 
            // res
            // 
            this.res.HeaderText = "(ni - npi)^2/npi";
            this.res.MinimumWidth = 6;
            this.res.Name = "res";
            this.res.Width = 125;
            // 
            // HipotesyX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 366);
            this.Controls.Add(this.raspredX);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HipotesyX";
            this.Text = "HypotesyX";
            this.Load += new System.EventHandler(this.Hipotesy_X_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raspredX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView raspredX;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn pi;
        private System.Windows.Forms.DataGridViewTextBoxColumn npi;
        private System.Windows.Forms.DataGridViewTextBoxColumn res;
    }
}