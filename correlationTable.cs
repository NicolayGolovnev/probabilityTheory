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

        public correlationTable(double[] X, double[] Y)
        {
            InitializeComponent();
            dataX = X;
            dataY = Y;

            double xMin = 1000, xMax = 0;
            double yMin = 1000, yMax = 0;
            for (int i = 0; i < Program.N; i++)
            {
                if (xMin > X[i])
                    xMin = X[i];
                if (xMax < X[i])
                    xMax = X[i];

                if (yMin > Y[i])
                    yMin = Y[i];
                if (yMax < Y[i])
                    yMax = Y[i];
            }

            //разрыв
            double Rx = Convert.ToDouble(xMax - xMin);
            double Ry = Convert.ToDouble(yMax - yMin);

            int Hx = (int)Math.Ceiling(Rx / Program.r);
            int Hy = (int)Math.Ceiling(Ry / Program.r);

            //Расширение промежутка
            double extendX = (Hx - (Rx / Program.r)) * Program.r;
            double extendY = (Hy - (Ry / Program.r)) * Program.r;

            //начало интервала(тк дробные, округляем в меньшую сторону)
            double beginX = Math.Floor(xMin) - Math.Floor(extendX / 2);
            double beginY = yMin - Math.Floor(extendY / 2);

            int[] dataIntervalsX = new int[8];
            int[] dataIntervalsY = new int[8];
            dataIntervalsX[0] = Convert.ToInt32(beginX);
            dataIntervalsY[0] = Convert.ToInt32(beginY);
            //заполнение таблицы
            for (int i = 0; i < Program.r; i++)
            {
                //интервал для X
                int a1X = Convert.ToInt32(beginX);
                int a2X = Convert.ToInt32(beginX + Hx);
                dataIntervalsX[i + 1] = a2X;
                beginX += Hx;

                //интервал для Y
                int a1Y = Convert.ToInt32(beginY);
                int a2Y = Convert.ToInt32(beginY + Hy);
                dataIntervalsY[i + 1] = a2Y;
                beginY += Hy;
            }

            intervalY[0, 0] = dataIntervalsY[0];
            intervalY[0, 1] = dataIntervalsY[1];

            intervalY[1, 0] = dataIntervalsY[1];
            intervalY[1, 1] = dataIntervalsY[2];

            intervalY[2, 0] = dataIntervalsY[2];
            intervalY[2, 1] = dataIntervalsY[3];

            intervalY[3, 0] = dataIntervalsY[3];
            intervalY[3, 1] = dataIntervalsY[4];

            intervalY[4, 0] = dataIntervalsY[4];
            intervalY[4, 1] = dataIntervalsY[5];

            intervalY[5, 0] = dataIntervalsY[5];
            intervalY[5, 1] = dataIntervalsY[6];

            intervalY[6, 0] = dataIntervalsY[6];
            intervalY[6, 1] = dataIntervalsY[7];


            intervalX[0, 0] = dataIntervalsX[0];
            intervalX[0, 1] = dataIntervalsX[1];

            intervalX[1, 0] = dataIntervalsX[1];
            intervalX[1, 1] = dataIntervalsX[2];

            intervalX[2, 0] = dataIntervalsX[2];
            intervalX[2, 1] = dataIntervalsX[3];

            intervalX[3, 0] = dataIntervalsX[3];
            intervalX[3, 1] = dataIntervalsX[4];

            intervalX[4, 0] = dataIntervalsX[4];
            intervalX[4, 1] = dataIntervalsX[5];

            intervalX[5, 0] = dataIntervalsX[5];
            intervalX[5, 1] = dataIntervalsX[6];

            intervalX[6, 0] = dataIntervalsX[6];
            intervalX[6, 1] = dataIntervalsX[7];


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
            
            //подсчитать коэф корреляции
        }
    }
}
