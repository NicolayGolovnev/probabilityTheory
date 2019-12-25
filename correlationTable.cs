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
    public partial class correlationTable : Form
    {
        public double[] dataX = new double[Program.N];
        public double[] dataY = new double[Program.N];

        public int[,] intervalY = new int[Program.r, 2];
        public int[,] intervalX = new int[Program.r, 2];

        public double correlCoef = new double();

        public int getInterX(double x)
        {
            for (int i = 0; i < Program.r; i++)
            {
                if (x < intervalX[i, 1])
                {
                    return i;
                }
                if (x == intervalX[Program.r - 1, 1])
                    return Program.r - 1;
            }
            return 0;
        }

        public int getInterY(double y)
        {
            for (int i = 0; i < Program.r; i++)
            {
                if (y < intervalY[i, 1])
                {
                    return i;
                }
                if (y == intervalY[Program.r - 1, 1])
                    return Program.r - 1;
            }
            return 0;
        }

        public correlationTable()
        {
            InitializeComponent();
        }

        public correlationTable(groupedRowX X, groupedRowY Y)
        {
            InitializeComponent();
            dataX = X.database;
            dataY = Y.database;

            intervalY[0, 0] = Y.dataIntervals[0];
            intervalY[0, 1] = Y.dataIntervals[1];

            intervalY[1, 0] = Y.dataIntervals[1];
            intervalY[1, 1] = Y.dataIntervals[2];

            intervalY[2, 0] = Y.dataIntervals[2];
            intervalY[2, 1] = Y.dataIntervals[3];

            intervalY[3, 0] = Y.dataIntervals[3];
            intervalY[3, 1] = Y.dataIntervals[4];

            intervalY[4, 0] = Y.dataIntervals[4];
            intervalY[4, 1] = Y.dataIntervals[5];

            intervalY[5, 0] = Y.dataIntervals[5];
            intervalY[5, 1] = Y.dataIntervals[6];

            intervalY[6, 0] = Y.dataIntervals[6];
            intervalY[6, 1] = Y.dataIntervals[7];


            intervalX[0, 0] = X.dataIntervals[0];
            intervalX[0, 1] = X.dataIntervals[1];

            intervalX[1, 0] = X.dataIntervals[1];
            intervalX[1, 1] = X.dataIntervals[2];

            intervalX[2, 0] = X.dataIntervals[2];
            intervalX[2, 1] = X.dataIntervals[3];

            intervalX[3, 0] = X.dataIntervals[3];
            intervalX[3, 1] = X.dataIntervals[4];

            intervalX[4, 0] = X.dataIntervals[4];
            intervalX[4, 1] = X.dataIntervals[5];

            intervalX[5, 0] = X.dataIntervals[5];
            intervalX[5, 1] = X.dataIntervals[6];

            intervalX[6, 0] = X.dataIntervals[6];
            intervalX[6, 1] = X.dataIntervals[7];


            table.Columns[1].HeaderText = "[" + Convert.ToString(intervalY[0, 0]) + ";" + Convert.ToString(intervalY[0, 1]) + ")";
            table.Columns[2].HeaderText = "[" + Convert.ToString(intervalY[1, 0]) + ";" + Convert.ToString(intervalY[1, 1]) + ")";
            table.Columns[3].HeaderText = "[" + Convert.ToString(intervalY[2, 0]) + ";" + Convert.ToString(intervalY[2, 1]) + ")";
            table.Columns[4].HeaderText = "[" + Convert.ToString(intervalY[3, 0]) + ";" + Convert.ToString(intervalY[3, 1]) + ")";
            table.Columns[5].HeaderText = "[" + Convert.ToString(intervalY[4, 0]) + ";" + Convert.ToString(intervalY[4, 1]) + ")";
            table.Columns[6].HeaderText = "[" + Convert.ToString(intervalY[5, 0]) + ";" + Convert.ToString(intervalY[5, 1]) + "]";
            table.Columns[7].HeaderText = "[" + Convert.ToString(intervalY[6, 0]) + ";" + Convert.ToString(intervalY[6, 1]) + "]";

            table.Rows.Add();
            table.Rows[0].Cells[0].Value = "[" + Convert.ToString(intervalX[0, 0]) + ";" + Convert.ToString(intervalX[0, 1]) + ")";
            table.Rows.Add();
            table.Rows[1].Cells[0].Value = "[" + Convert.ToString(intervalX[1, 0]) + ";" + Convert.ToString(intervalX[1, 1]) + ")";
            table.Rows.Add();
            table.Rows[2].Cells[0].Value = "[" + Convert.ToString(intervalX[2, 0]) + ";" + Convert.ToString(intervalX[2, 1]) + ")";
            table.Rows.Add();
            table.Rows[3].Cells[0].Value = "[" + Convert.ToString(intervalX[3, 0]) + ";" + Convert.ToString(intervalX[3, 1]) + ")";
            table.Rows.Add();
            table.Rows[4].Cells[0].Value = "[" + Convert.ToString(intervalX[4, 0]) + ";" + Convert.ToString(intervalX[4, 1]) + ")";
            table.Rows.Add();
            table.Rows[5].Cells[0].Value = "[" + Convert.ToString(intervalX[5, 0]) + ";" + Convert.ToString(intervalX[5, 1]) + "]";
            table.Rows.Add();
            table.Rows[6].Cells[0].Value = "[" + Convert.ToString(intervalX[6, 0]) + ";" + Convert.ToString(intervalX[6, 1]) + "]";

            table.Rows.Add();
            table.Rows[7].Cells[0].Value = "nj";

            for (int i = 0; i < Program.N; i++)
                table.Rows[getInterX(dataX[i])].Cells[getInterY(dataY[i]) + 1].Value = Convert.ToString(Convert.ToInt32(table.Rows[getInterX(dataX[i])].Cells[getInterY(dataY[i]) + 1].Value) + 1);

            for (int i = 1; i <= Program.r; i++)
            {
                int a = 0;
                for (int j = 0; j < Program.r; j++)
                    a += Convert.ToInt32(table.Rows[j].Cells[i].Value);
                table.Rows[7].Cells[i].Value = Convert.ToString(a);
            }

            for (int i = 0; i < Program.r; i++)
            {
                int a = 0;
                for (int j = 1; j <= Program.r; j++)
                    a += Convert.ToInt32(table.Rows[i].Cells[j].Value);
                table.Rows[i].Cells[8].Value = Convert.ToString(a);
            }
            table.Rows[7].Cells[8].Value = "∑=50";


            //подсчитать коэф корреляции

            int k1 = (int)X.dataAverage[3];
            pointEstimates pointX = new pointEstimates(1, k1, X.dataAverage, X.Hx, X.dataFrequency);

            int k2 = (int)Y.dataAverage[3];
            pointEstimates pointY = new pointEstimates(2, k2, Y.dataAverage, Y.Hy, Y.dataFrequency);

            double uvAvg = 0;
            for (int i = 0; i < Program.r; i++)
                for (int j = 0; j < Program.r; j++)
                    uvAvg += pointX.U[i] * pointY.U[j] * Convert.ToDouble(table.Rows[i].Cells[j + 1].Value);
            uvAvg /= (double)Program.N;

            correlCoef = (double)Program.N / (double)(Program.N - 1) * (uvAvg - pointX.uAverage * pointY.uAverage) / Math.Sqrt(pointX.SuTwice) / Math.Sqrt(pointY.SuTwice);
            /*double _out1 = (double)Program.N / (double)(Program.N - 1);
            double _out2 = xyAvg;
            double _out3 = (xyAvg - pointX.xAverage * pointY.xAverage);
            double _out4 = pointX.Sx * pointY.Sx;*/
            textBox_correlCoef.Text = String.Format("{0:0,00}", Convert.ToString(correlCoef));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            regressionChart grph = new regressionChart(dataX, dataY, correlCoef);
            grph.Show();
        }
    }
}
