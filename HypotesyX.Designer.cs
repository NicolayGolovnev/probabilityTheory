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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raspredX)).BeginInit();
            this.SuspendLayout();
            // 
            // raspredX
            // 
            this.raspredX.AllowUserToAddRows = false;
            this.raspredX.AllowUserToDeleteRows = false;
            this.raspredX.AllowUserToResizeColumns = false;
            this.raspredX.AllowUserToResizeRows = false;
            this.raspredX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.raspredX.Dock = System.Windows.Forms.DockStyle.Top;
            this.raspredX.Location = new System.Drawing.Point(0, 0);
            this.raspredX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.raspredX.Name = "raspredX";
            this.raspredX.RowHeadersVisible = false;
            this.raspredX.RowHeadersWidth = 51;
            this.raspredX.RowTemplate.Height = 24;
            this.raspredX.Size = new System.Drawing.Size(717, 316);
            this.raspredX.TabIndex = 0;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.MinimumWidth = 6;
            this.i.Name = "i";
            // 
            // inter
            // 
            this.inter.HeaderText = "interval";
            this.inter.MinimumWidth = 6;
            this.inter.Name = "inter";
            // 
            // ni
            // 
            this.ni.HeaderText = "Ni";
            this.ni.MinimumWidth = 6;
            this.ni.Name = "ni";
            // 
            // Zi
            // 
            this.Zi.HeaderText = "Zi";
            this.Zi.MinimumWidth = 6;
            this.Zi.Name = "Zi";
            // 
            // Fi
            // 
            this.Fi.HeaderText = "Фi";
            this.Fi.MinimumWidth = 6;
            this.Fi.Name = "Fi";
            // 
            // pi
            // 
            this.pi.HeaderText = "Pi";
            this.pi.MinimumWidth = 6;
            this.pi.Name = "pi";
            // 
            // npi
            // 
            this.npi.HeaderText = "npi";
            this.npi.MinimumWidth = 6;
            this.npi.Name = "npi";
            // 
            // res
            // 
            this.res.HeaderText = "(ni - npi)^2/npi";
            this.res.MinimumWidth = 6;
            this.res.Name = "res";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число интервалов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Х^2 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Хв^2 = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Точность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Х(0.95)^2 = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(369, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(369, 446);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "label13";
            // 
            // HipotesyX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 523);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raspredX);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HipotesyX";
            this.Text = "HypotesyX";
            this.Load += new System.EventHandler(this.Hipotesy_X_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raspredX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}