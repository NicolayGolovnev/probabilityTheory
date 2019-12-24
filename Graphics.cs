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
    public partial class Graphics : Form
    {
        public double[] dataPoligon = new double[Program.r];
        public double[] dataGist = new double[Program.r];
        public double[] dataAverage = new double[Program.r];
        public double[] dataIntervals = new double[8];
        public double[] dataEmpiric = new double[Program.r];
        public int Hx;
        public double[] func_X = new double[Program.r + 2];
        public double[] func_int_X = new double[Program.r + 2];
        public int[,] interval = new int[Program.r, 2];

        public Graphics(int value,int[] intervals, double[] poligon, double[] gist, double[] average, 
                            double[] empiric, int hx)
        {
            InitializeComponent();
            for (int i = 0; i < 8; i++)
                dataIntervals[i] = Convert.ToDouble(intervals[i]);
            dataPoligon = poligon;
            dataGist = gist;
            dataAverage = average;
            dataEmpiric = empiric;
            Hx = hx;

            //Генерация интервалов
            interval[0, 0] = intervals[0];
            interval[0, 1] = intervals[1];

            interval[1, 0] = intervals[1];
            interval[1, 1] = intervals[2];

            interval[2, 0] = intervals[2];
            interval[2, 1] = intervals[3];

            interval[3, 0] = intervals[3];
            interval[3, 1] = intervals[4];

            interval[4, 0] = intervals[4];
            interval[4, 1] = intervals[5];

            interval[5, 0] = intervals[5];
            interval[5, 1] = intervals[6];

            interval[6, 0] = intervals[6];
            interval[6, 1] = intervals[7];

            //генерация данных для эмпирической функции
            func_X[0] = 0;
            func_int_X[0] = interval[0, 0] - Hx;
            for (int j = 0; j < Program.r; j++)
            {
                func_X[j + 1] = dataEmpiric[j];
                func_int_X[j + 1] = interval[j, 0];
            }
            func_X[8] = dataEmpiric[6];
            func_int_X[8] = interval[6, 1];

            if (value == 1)
                this.Text = "Графики для группированного ряда X";
            else
                this.Text = "Графики для группированного ряда Y";

            chart_Poligon.Series["nᵢ / n"].Points.DataBindXY(dataAverage, dataPoligon);
            chart_Poligon.ChartAreas["ChartArea1"].AxisX.Interval = Hx;

            chart_Gist.Series["nᵢ / (n ∙ h)"].Points.DataBindXY(dataAverage, dataGist);
            chart_Gist.ChartAreas["ChartArea1"].AxisX.Interval = Hx;
            chart_Gist.ChartAreas["ChartArea1"].AxisX.IntervalOffset = Hx / 2;

            chart_Empiric.Series["∑(nᵢ / n)"].Points.DataBindXY(func_int_X, func_X);
            chart_Empiric.ChartAreas["ChartArea1"].AxisX.Interval = Hx;
        }
    }
}
