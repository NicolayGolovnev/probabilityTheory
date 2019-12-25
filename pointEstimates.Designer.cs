namespace Zaychik
{
    partial class pointEstimates
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
            this.marks = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UiNi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UiNiTwice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_uAvg = new System.Windows.Forms.TextBox();
            this.textBox_uAvgTwice = new System.Windows.Forms.TextBox();
            this.textBox_SuTwice = new System.Windows.Forms.TextBox();
            this.textBox_Sx = new System.Windows.Forms.TextBox();
            this.textBox_SxTwice = new System.Windows.Forms.TextBox();
            this.textBox_xAvg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.marks)).BeginInit();
            this.SuspendLayout();
            // 
            // marks
            // 
            this.marks.AllowUserToAddRows = false;
            this.marks.AllowUserToDeleteRows = false;
            this.marks.AllowUserToResizeColumns = false;
            this.marks.AllowUserToResizeRows = false;
            this.marks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.Ui,
            this.Ni,
            this.UiNi,
            this.UiNiTwice});
            this.marks.Location = new System.Drawing.Point(13, 13);
            this.marks.Name = "marks";
            this.marks.RowHeadersVisible = false;
            this.marks.RowHeadersWidth = 62;
            this.marks.RowTemplate.Height = 28;
            this.marks.Size = new System.Drawing.Size(836, 340);
            this.marks.TabIndex = 0;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.MinimumWidth = 8;
            this.i.Name = "i";
            // 
            // Ui
            // 
            this.Ui.HeaderText = "uᵢ";
            this.Ui.MinimumWidth = 8;
            this.Ui.Name = "Ui";
            // 
            // Ni
            // 
            this.Ni.HeaderText = "nᵢ";
            this.Ni.MinimumWidth = 8;
            this.Ni.Name = "Ni";
            // 
            // UiNi
            // 
            this.UiNi.HeaderText = "uᵢ ∙ nᵢ";
            this.UiNi.MinimumWidth = 8;
            this.UiNi.Name = "UiNi";
            // 
            // UiNiTwice
            // 
            this.UiNiTwice.HeaderText = "u²ᵢ ∙ nᵢ";
            this.UiNiTwice.MinimumWidth = 8;
            this.UiNiTwice.Name = "UiNiTwice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // textBox_uAvg
            // 
            this.textBox_uAvg.Location = new System.Drawing.Point(148, 372);
            this.textBox_uAvg.Name = "textBox_uAvg";
            this.textBox_uAvg.Size = new System.Drawing.Size(100, 26);
            this.textBox_uAvg.TabIndex = 4;
            // 
            // textBox_uAvgTwice
            // 
            this.textBox_uAvgTwice.Location = new System.Drawing.Point(148, 411);
            this.textBox_uAvgTwice.Name = "textBox_uAvgTwice";
            this.textBox_uAvgTwice.Size = new System.Drawing.Size(100, 26);
            this.textBox_uAvgTwice.TabIndex = 5;
            // 
            // textBox_SuTwice
            // 
            this.textBox_SuTwice.Location = new System.Drawing.Point(148, 447);
            this.textBox_SuTwice.Name = "textBox_SuTwice";
            this.textBox_SuTwice.Size = new System.Drawing.Size(100, 26);
            this.textBox_SuTwice.TabIndex = 6;
            // 
            // textBox_Sx
            // 
            this.textBox_Sx.Location = new System.Drawing.Point(603, 447);
            this.textBox_Sx.Name = "textBox_Sx";
            this.textBox_Sx.Size = new System.Drawing.Size(100, 26);
            this.textBox_Sx.TabIndex = 12;
            // 
            // textBox_SxTwice
            // 
            this.textBox_SxTwice.Location = new System.Drawing.Point(603, 411);
            this.textBox_SxTwice.Name = "textBox_SxTwice";
            this.textBox_SxTwice.Size = new System.Drawing.Size(100, 26);
            this.textBox_SxTwice.TabIndex = 11;
            // 
            // textBox_xAvg
            // 
            this.textBox_xAvg.Location = new System.Drawing.Point(603, 372);
            this.textBox_xAvg.Name = "textBox_xAvg";
            this.textBox_xAvg.Size = new System.Drawing.Size(100, 26);
            this.textBox_xAvg.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "label6";
            // 
            // pointEstimates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 488);
            this.Controls.Add(this.textBox_Sx);
            this.Controls.Add(this.textBox_SxTwice);
            this.Controls.Add(this.textBox_xAvg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_SuTwice);
            this.Controls.Add(this.textBox_uAvgTwice);
            this.Controls.Add(this.textBox_uAvg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marks);
            this.Name = "pointEstimates";
            this.Text = "Точечные оценки";
            ((System.ComponentModel.ISupportInitialize)(this.marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ni;
        private System.Windows.Forms.DataGridViewTextBoxColumn UiNi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UiNiTwice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_uAvg;
        private System.Windows.Forms.TextBox textBox_uAvgTwice;
        private System.Windows.Forms.TextBox textBox_SuTwice;
        private System.Windows.Forms.TextBox textBox_Sx;
        private System.Windows.Forms.TextBox textBox_SxTwice;
        private System.Windows.Forms.TextBox textBox_xAvg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}