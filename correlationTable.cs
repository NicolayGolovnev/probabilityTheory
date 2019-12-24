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

        public correlationTable(double[] X, double[] Y, groupedRowX rowX, groupedRowY rowY)
        {
            InitializeComponent();
            dataX = X;
            dataY = Y;

            intervalY[0, 0] = rowY.dataIntervals[0];
            intervalY[0, 1] = rowY.dataIntervals[1];

            intervalY[1, 0] = rowY.dataIntervals[1];
            intervalY[1, 1] = rowY.dataIntervals[2];

            intervalY[2, 0] = rowY.dataIntervals[2];
            intervalY[2, 1] = rowY.dataIntervals[3];

            intervalY[3, 0] = rowY.dataIntervals[3];
            intervalY[3, 1] = rowY.dataIntervals[4];

            intervalY[4, 0] = rowY.dataIntervals[4];
            intervalY[4, 1] = rowY.dataIntervals[5];

            intervalY[5, 0] = rowY.dataIntervals[5];
            intervalY[5, 1] = rowY.dataIntervals[6];

            intervalY[6, 0] = rowY.dataIntervals[6];
            intervalY[6, 1] = rowY.dataIntervals[7];


            intervalX[0, 0] = rowX.dataIntervals[0];
            intervalX[0, 1] = rowX.dataIntervals[1];

            intervalX[1, 0] = rowX.dataIntervals[1];
            intervalX[1, 1] = rowX.dataIntervals[2];

            intervalX[2, 0] = rowX.dataIntervals[2];
            intervalX[2, 1] = rowX.dataIntervals[3];

            intervalX[3, 0] = rowX.dataIntervals[3];
            intervalX[3, 1] = rowX.dataIntervals[4];

            intervalX[4, 0] = rowX.dataIntervals[4];
            intervalX[4, 1] = rowX.dataIntervals[5];

            intervalX[5, 0] = rowX.dataIntervals[5];
            intervalX[5, 1] = rowX.dataIntervals[6];

            intervalX[6, 0] = rowX.dataIntervals[6];
            intervalX[6, 1] = rowX.dataIntervals[7];


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
