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
    public partial class groupedRowY : Form
    {
        public double[] database = new double[Program.N];
        public double[] dataPoligon = new double[Program.r];
        public double[] dataGist = new double[Program.r];
        public double[] dataAverage = new double[Program.r];
        public double[] dataFrequency = new double[Program.r];
        public int[] dataIntervals = new int[8];
        public double[] dataEmpiric = new double[Program.r];
        public int Hy = new int();
        public double yMin = new double();
        public double yMax = new double();
        public double Ry = new double();

        public Graphics grph;
        public pointEstimates point;
        public HipotesyX hip;
        public confidenceIntervals inter;
        public groupedRowY()
        {
            InitializeComponent();

        }

        public groupedRowY(double[] data)
        {
            InitializeComponent();
            database = data;

            //заполняем таблицу
            double xMin = 1000, xMax = 0;

            //max, min
            for (int i = 0; i < Program.N; i++)
            {
                if (xMin > database[i])
                    xMin = database[i];
                if (xMax < database[i])
                    xMax = database[i];
            }
            this.yMin = xMin;
            this.yMax = xMax;

            //разрыв
            double Rx = Convert.ToDouble(xMax - xMin);
            this.Ry = Rx;
            //вывод Rx

            int Hx = (int)Math.Ceiling(Rx / Program.r);
            this.Hy = Hx;
            //вывод Hx

            //Расширение промежутка
            double extendX = (Hx - (Rx / Program.r)) * Program.r;

            //начало интервала(тк дробные, округляем в меньшую сторону)
            double begin = Math.Floor(xMin) - Math.Floor(extendX / 2);

            //Подсчитываем N
            for (int i = 0; i < 7; i++)
                dataFrequency[i] = 0;

            for (int i = 0; i < Program.N; i++)
            {
                if (begin <= database[i] && database[i] < begin + Hx)
                    dataFrequency[0]++;
                else if (begin + Hx <= database[i] && database[i] < begin + Hx * 2)
                    dataFrequency[1]++;
                else if (begin + Hx * 2 <= database[i] && database[i] < begin + Hx * 3)
                    dataFrequency[2]++;
                else if (begin + Hx * 3 <= database[i] && database[i] < begin + Hx * 4)
                    dataFrequency[3]++;
                else if (begin + Hx * 4 <= database[i] && database[i] < begin + Hx * 5)
                    dataFrequency[4]++;
                else if (begin + Hx * 5 <= database[i] && database[i] < begin + Hx * 6)
                    dataFrequency[5]++;
                else if (begin + Hx * 6 <= database[i] && database[i] < begin + Hx * 7)
                    dataFrequency[6]++;
            }

            dataIntervals[0] = Convert.ToInt32(begin);

            double buf = 0;
            for (int i = 0; i < Program.r; i++)
            {
                //интервал
                int a1 = Convert.ToInt32(begin);
                int a2 = Convert.ToInt32(begin + Hx);
                dataIntervals[i + 1] = a2;
                begin += Hx;

                dataAverage[i] = Convert.ToDouble((a2 + a1) / 2);
                dataPoligon[i] = dataFrequency[i] / Program.N;
                dataGist[i] = dataPoligon[i] / Hx;

                //подсчитываем функцию распределения через сумму пред. Ni/N
                if (i == 0)
                    buf = dataPoligon[i];
                else
                    buf += dataPoligon[i];
                dataEmpiric[i] = buf;
            }
        }

        private void groupedRowY_Load(object sender, EventArgs e)
        {
            int begin = dataIntervals[0];

            table.Rows.Clear();
            for (int i = 0; i < Program.r; i++)
            {
                table.Rows.Add();
                table.Rows[i].Cells[0].Value = i + 1;

                //интервал
                int a1 = Convert.ToInt32(begin);
                int a2 = Convert.ToInt32(begin + Hy);
                begin += Hy;

                if (i == Program.r - 1)
                    table.Rows[i].Cells[1].Value = "[" + a1 + ";" + a2 + "]";
                else
                    table.Rows[i].Cells[1].Value = "[" + a1 + ";" + a2 + ")";

                table.Rows[i].Cells[2].Value = dataFrequency[i];
                table.Rows[i].Cells[3].Value = dataAverage[i];
                table.Rows[i].Cells[4].Value = dataPoligon[i];
                table.Rows[i].Cells[5].Value = dataGist[i];
                table.Rows[i].Cells[6].Value = dataEmpiric[i];
            }

            //заполняем текст боксы
            textBox_Xmin.Text = String.Format("{0:0.00}", Convert.ToString(yMin));
            textBox_Xmax.Text = String.Format("{0:0.00}", Convert.ToString(yMax));
            textBox_Rx.Text = String.Format("{0:0.00}", Convert.ToString(Ry));
            textBox_r.Text = String.Format("{0:0.00}", Convert.ToString(Program.r));
            textBox_Hx.Text = String.Format("{0:0.00}", Convert.ToString(Hy));

            grph = new Graphics(1, dataIntervals, dataPoligon, dataGist, dataAverage, dataEmpiric, Hy);
            int k = (int)dataAverage[3];
            point = new pointEstimates(2, k, dataAverage, Hy, dataFrequency);
            hip = new HipotesyX();
            inter = new confidenceIntervals(2, point);
        }

        private void button_graphics_Click(object sender, EventArgs e)
        {
            //надо передать новой форме, где будут графики данные 
            //Для полигона - средние значения и dataPoligon
            //Для гистограммы - интервалы и dataGist
            //Для эмпирик функ - интервалы и dataEmpiric

            //создаем форму графика
            Graphics grph = new Graphics(2, dataIntervals, dataPoligon, dataGist, dataAverage, dataEmpiric, Hy);
            grph.Show();
        }

        private void button_pointEstimates_Click(object sender, EventArgs e)
        {
            point.Show();
        }

        private void button_hypothesis_Click(object sender, EventArgs e)
        {
            hip.doY = true;
            hip.Show();
        }

        private void button_confidenceIntervals_Click(object sender, EventArgs e)
        {
            inter.Show();
        }
    }
}
