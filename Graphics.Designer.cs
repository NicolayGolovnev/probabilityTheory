namespace Zaychik
{
    partial class Graphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Poligon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Gist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_Empiric = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Poligon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Gist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Empiric)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Poligon
            // 
            chartArea4.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea4.AxisX.LineWidth = 2;
            chartArea4.AxisX.Title = "x˟ᵢ";
            chartArea4.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea4.AxisY.LineWidth = 2;
            chartArea4.AxisY.Title = "nᵢ / n";
            chartArea4.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea4.Name = "ChartArea1";
            this.chart_Poligon.ChartAreas.Add(chartArea4);
            this.chart_Poligon.Location = new System.Drawing.Point(25, 49);
            this.chart_Poligon.Name = "chart_Poligon";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.MarkerColor = System.Drawing.Color.Red;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series4.Name = "nᵢ / n";
            this.chart_Poligon.Series.Add(series4);
            this.chart_Poligon.Size = new System.Drawing.Size(440, 440);
            this.chart_Poligon.TabIndex = 0;
            this.chart_Poligon.Text = "chart_Poligon";
            // 
            // chart_Gist
            // 
            chartArea5.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea5.AxisX.LineWidth = 2;
            chartArea5.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea5.AxisX.Title = "aᵢ";
            chartArea5.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea5.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea5.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea5.AxisY.LineWidth = 2;
            chartArea5.AxisY.Title = "nᵢ / (n ∙ h)";
            chartArea5.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea5.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea5.Name = "ChartArea1";
            this.chart_Gist.ChartAreas.Add(chartArea5);
            this.chart_Gist.Location = new System.Drawing.Point(505, 49);
            this.chart_Gist.Name = "chart_Gist";
            this.chart_Gist.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series5.ChartArea = "ChartArea1";
            series5.CustomProperties = "DrawingStyle=Emboss, PointWidth=1";
            series5.IsVisibleInLegend = false;
            series5.Name = "nᵢ / (n ∙ h)";
            this.chart_Gist.Series.Add(series5);
            this.chart_Gist.Size = new System.Drawing.Size(440, 440);
            this.chart_Gist.TabIndex = 1;
            this.chart_Gist.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(198, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Полигон:";
            // 
            // chart_Empiric
            // 
            chartArea6.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea6.AxisX.LineWidth = 2;
            chartArea6.AxisX.Title = "aᵢ";
            chartArea6.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea6.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea6.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea6.AxisY.LineWidth = 2;
            chartArea6.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea6.AxisY.Title = "Fn(x)";
            chartArea6.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea6.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea6.Name = "ChartArea1";
            this.chart_Empiric.ChartAreas.Add(chartArea6);
            this.chart_Empiric.Location = new System.Drawing.Point(973, 49);
            this.chart_Empiric.Name = "chart_Empiric";
            this.chart_Empiric.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series6.MarkerColor = System.Drawing.Color.Red;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series6.Name = "∑(nᵢ / n)";
            this.chart_Empiric.Series.Add(series6);
            this.chart_Empiric.Size = new System.Drawing.Size(440, 440);
            this.chart_Empiric.TabIndex = 3;
            this.chart_Empiric.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(662, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Гистограмма:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(983, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Эмпирическая функция распределения";
            // 
            // Graphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart_Empiric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_Gist);
            this.Controls.Add(this.chart_Poligon);
            this.Name = "Graphics";
            this.Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Poligon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Gist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Empiric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Poligon;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Gist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Empiric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}