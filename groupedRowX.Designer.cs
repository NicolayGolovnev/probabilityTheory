namespace Zaychik
{
    partial class groupedRowX
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
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightPoligon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightGist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Xmin = new System.Windows.Forms.TextBox();
            this.textBox_Rx = new System.Windows.Forms.TextBox();
            this.textBox_Xmax = new System.Windows.Forms.TextBox();
            this.textBox_r = new System.Windows.Forms.TextBox();
            this.textBox_Hx = new System.Windows.Forms.TextBox();
            this.textBox_extend = new System.Windows.Forms.TextBox();
            this.button_graphics = new System.Windows.Forms.Button();
            this.button_pointEstimates = new System.Windows.Forms.Button();
            this.button_hypothesis = new System.Windows.Forms.Button();
            this.button_confidenceIntervals = new System.Windows.Forms.Button();
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
            this.value,
            this.range,
            this.count,
            this.Average,
            this.HeightPoligon,
            this.HeightGist,
            this.Func});
            this.table.EnableHeadersVisualStyles = false;
            this.table.Location = new System.Drawing.Point(13, 13);
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 62;
            this.table.RowTemplate.Height = 28;
            this.table.Size = new System.Drawing.Size(776, 250);
            this.table.TabIndex = 0;
            // 
            // value
            // 
            this.value.HeaderText = "i";
            this.value.MinimumWidth = 8;
            this.value.Name = "value";
            // 
            // range
            // 
            this.range.HeaderText = "[aᵢ₋₁ ; aᵢ)";
            this.range.MinimumWidth = 8;
            this.range.Name = "range";
            // 
            // count
            // 
            this.count.HeaderText = "nᵢ";
            this.count.MinimumWidth = 8;
            this.count.Name = "count";
            // 
            // Average
            // 
            this.Average.HeaderText = "X˟ᵢ";
            this.Average.MinimumWidth = 8;
            this.Average.Name = "Average";
            // 
            // HeightPoligon
            // 
            this.HeightPoligon.HeaderText = "nᵢ / n";
            this.HeightPoligon.MinimumWidth = 8;
            this.HeightPoligon.Name = "HeightPoligon";
            // 
            // HeightGist
            // 
            this.HeightGist.HeaderText = "nᵢ /(n∙h)";
            this.HeightGist.MinimumWidth = 8;
            this.HeightGist.Name = "HeightGist";
            // 
            // Func
            // 
            this.Func.HeaderText = "Fn(X)";
            this.Func.MinimumWidth = 8;
            this.Func.Name = "Func";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xmin = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xmax = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Размах выбоки R = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Кол-во интервалов r = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Длина интервала h = ";
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.Location = new System.Drawing.Point(12, 369);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(131, 72);
            this.label6.TabIndex = 6;
            this.label6.Text = "Расширение промежутка разбиения";
            // 
            // textBox_Xmin
            // 
            this.textBox_Xmin.Location = new System.Drawing.Point(80, 280);
            this.textBox_Xmin.Name = "textBox_Xmin";
            this.textBox_Xmin.Size = new System.Drawing.Size(56, 26);
            this.textBox_Xmin.TabIndex = 7;
            // 
            // textBox_Rx
            // 
            this.textBox_Rx.Location = new System.Drawing.Point(517, 280);
            this.textBox_Rx.Name = "textBox_Rx";
            this.textBox_Rx.Size = new System.Drawing.Size(100, 26);
            this.textBox_Rx.TabIndex = 9;
            // 
            // textBox_Xmax
            // 
            this.textBox_Xmax.Location = new System.Drawing.Point(238, 280);
            this.textBox_Xmax.Name = "textBox_Xmax";
            this.textBox_Xmax.Size = new System.Drawing.Size(56, 26);
            this.textBox_Xmax.TabIndex = 10;
            // 
            // textBox_r
            // 
            this.textBox_r.Location = new System.Drawing.Point(200, 322);
            this.textBox_r.Name = "textBox_r";
            this.textBox_r.Size = new System.Drawing.Size(100, 26);
            this.textBox_r.TabIndex = 11;
            // 
            // textBox_Hx
            // 
            this.textBox_Hx.Location = new System.Drawing.Point(517, 322);
            this.textBox_Hx.Name = "textBox_Hx";
            this.textBox_Hx.Size = new System.Drawing.Size(100, 26);
            this.textBox_Hx.TabIndex = 12;
            // 
            // textBox_extend
            // 
            this.textBox_extend.Location = new System.Drawing.Point(149, 388);
            this.textBox_extend.Name = "textBox_extend";
            this.textBox_extend.Size = new System.Drawing.Size(100, 26);
            this.textBox_extend.TabIndex = 13;
            // 
            // button_graphics
            // 
            this.button_graphics.Location = new System.Drawing.Point(299, 367);
            this.button_graphics.Name = "button_graphics";
            this.button_graphics.Size = new System.Drawing.Size(103, 69);
            this.button_graphics.TabIndex = 14;
            this.button_graphics.Text = "Графики";
            this.button_graphics.UseVisualStyleBackColor = true;
            this.button_graphics.Click += new System.EventHandler(this.button_graphics_Click);
            // 
            // button_pointEstimates
            // 
            this.button_pointEstimates.Location = new System.Drawing.Point(424, 367);
            this.button_pointEstimates.Name = "button_pointEstimates";
            this.button_pointEstimates.Size = new System.Drawing.Size(103, 69);
            this.button_pointEstimates.TabIndex = 15;
            this.button_pointEstimates.Text = "Точечные оценки";
            this.button_pointEstimates.UseVisualStyleBackColor = true;
            this.button_pointEstimates.Click += new System.EventHandler(this.button_pointEstimates_Click);
            // 
            // button_hypothesis
            // 
            this.button_hypothesis.Location = new System.Drawing.Point(543, 367);
            this.button_hypothesis.Name = "button_hypothesis";
            this.button_hypothesis.Size = new System.Drawing.Size(103, 69);
            this.button_hypothesis.TabIndex = 16;
            this.button_hypothesis.Text = "Проверка гипотезы";
            this.button_hypothesis.UseVisualStyleBackColor = true;
            // 
            // button_confidenceIntervals
            // 
            this.button_confidenceIntervals.Location = new System.Drawing.Point(672, 368);
            this.button_confidenceIntervals.Name = "button_confidenceIntervals";
            this.button_confidenceIntervals.Size = new System.Drawing.Size(147, 69);
            this.button_confidenceIntervals.TabIndex = 17;
            this.button_confidenceIntervals.Text = "Доверительные интервалы";
            this.button_confidenceIntervals.UseVisualStyleBackColor = true;
            this.button_confidenceIntervals.Click += new System.EventHandler(this.button_confidenceIntervals_Click);
            // 
            // groupedRowX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.button_confidenceIntervals);
            this.Controls.Add(this.button_hypothesis);
            this.Controls.Add(this.button_pointEstimates);
            this.Controls.Add(this.button_graphics);
            this.Controls.Add(this.textBox_extend);
            this.Controls.Add(this.textBox_Hx);
            this.Controls.Add(this.textBox_r);
            this.Controls.Add(this.textBox_Xmax);
            this.Controls.Add(this.textBox_Rx);
            this.Controls.Add(this.textBox_Xmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table);
            this.Name = "groupedRowX";
            this.Text = "groupedRowX";
            this.Load += new System.EventHandler(this.groupedRowX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn range;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightPoligon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightGist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Xmin;
        private System.Windows.Forms.TextBox textBox_Rx;
        private System.Windows.Forms.TextBox textBox_Xmax;
        private System.Windows.Forms.TextBox textBox_r;
        private System.Windows.Forms.TextBox textBox_Hx;
        private System.Windows.Forms.TextBox textBox_extend;
        private System.Windows.Forms.Button button_graphics;
        private System.Windows.Forms.Button button_pointEstimates;
        private System.Windows.Forms.Button button_hypothesis;
        private System.Windows.Forms.Button button_confidenceIntervals;
    }
}