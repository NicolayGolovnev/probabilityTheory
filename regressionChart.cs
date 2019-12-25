using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaychik
{
    public partial class regressionChart : Form
    {
        public double[] dataX = new double[Program.N];
        public double[] dataY = new double[Program.N];
        public double rv = new double();


        public regressionChart()
        {
            InitializeComponent();
        }

        public regressionChart(double[] X, double[] Y, double rv)
        {
            InitializeComponent();

            dataX = X;
            dataY = Y;
            this.rv = rv;
        }

        private void regressionChart_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.DataBindXY(dataX, dataY);

            //вычислить 1 выбор. уравнение, построить прямую по 2 точкам - минимум и максимум
            groupedRowX X = new groupedRowX(dataX);
            groupedRowY Y = new groupedRowY(dataY);
            int k1 = (int)X.dataAverage[3];
            int k2 = (int)Y.dataAverage[3];
            pointEstimates pointX = new pointEstimates(1, k1, X.dataAverage, X.Hx, X.dataFrequency);
            pointEstimates pointY = new pointEstimates(2, k2, Y.dataAverage, Y.Hy, Y.dataFrequency);

            double kY = rv * Math.Sqrt(pointY.SuTwice) / Math.Sqrt(pointX.SuTwice);
            double kX = rv * Math.Sqrt(pointX.SuTwice) / Math.Sqrt(pointY.SuTwice);

            double cnstX = (-1) * kX * pointX.xAverage + pointY.xAverage;
            double cnstY = (-1) * kY * pointY.xAverage + pointX.xAverage;

            //1 график
            double xX1 = pointX.xAverage - 30;
            double xX2 = pointX.xAverage + 30;
            double yX1 = kX * xX1 + cnstX;
            double yX2 = kX * xX2 + cnstX;
            //Y для 2 графика
            double xY1 = pointX.xAverage - 30;
            double xY2 = pointX.xAverage + 30;
            double yY1 = (xY1 - cnstY) / kY;
            double yY2 = (xY2 - cnstY) / kY;

            chart1.ChartAreas[0].AxisX.Interval = 7;
            chart1.ChartAreas[0].AxisY.Interval = 7;
            chart1.ChartAreas[0].AxisX.Minimum = Math.Floor(xX1);
            chart1.ChartAreas[0].AxisY.Minimum = Math.Floor(yX1);

            //строим 1 график
            chart1.Series[1].Color = Color.Blue;
            chart1.Series[2].BorderWidth = 3;
            chart1.Series[1].Points.AddXY(xY1, yY1);
            chart1.Series[1].Points.AddXY(xY2, yY2);

            //строим 2 график
            chart1.Series[2].Color = Color.Green;
            chart1.Series[2].BorderWidth = 3;
            chart1.Series[2].Points.AddXY(xX1, yX1);
            chart1.Series[2].Points.AddXY(xX2, yX2);

            if (cnstX > 0)
                chart1.Series[2].LegendText = "y = " + String.Format("{0:0.00}", kX) + "x + " + String.Format("{0:0.00}", Math.Abs(cnstX));
            else if (cnstX < 0)
                chart1.Series[2].LegendText = "y = " + String.Format("{0:0.00}", kX) + "x - " + String.Format("{0:0.00}", Math.Abs(cnstX));
            else
                chart1.Series[2].LegendText = "y = " + String.Format("{0:0.00}", kX) + "x";
            

            if (cnstY > 0)
                chart1.Series[1].LegendText = "x = " + String.Format("{0:0.00}", kY) + "y + " + String.Format("{0:0.00}", Math.Abs(cnstY));
            else if (cnstY < 0)
                chart1.Series[1].LegendText = "x = " + String.Format("{0:0.00}", kY) + "y - " + String.Format("{0:0.00}", Math.Abs(cnstY));
            else
                chart1.Series[1].LegendText = "x = " + String.Format("{0:0.00}", kY) + "y";
        }
    }
}
