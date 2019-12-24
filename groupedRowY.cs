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
        public int Hx = new int();
        public groupedRowY()
        {
            InitializeComponent();

        }

        private void groupedRowX_Load(object sender, EventArgs e)
        {
            //заполняем таблицу
            double xMin = 1000, xMax = 0;
            int yMin = 1000, yMax = 0;

            //max, min
            for (int i = 0; i < Program.N; i++)
            {
                if (xMin > database[i])
                    xMin = database[i];
                if (xMax < database[i])
                    xMax = database[i];
            }

            //разрыв
            double Rx = Convert.ToDouble(xMax - xMin);
            //вывод Rx

            int Hx = (int)Math.Ceiling(Rx / Program.r);
            this.Hx = Hx;
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
            //заполнение таблицы
            for (int i = 0; i < Program.r; i++)
            {
                table.Rows.Add();

                table.Rows[i].Cells[0].Value = i + 1;
                
                //интервал
                int a1 = Convert.ToInt32(begin);
                int a2 = Convert.ToInt32(begin + Hx);
                dataIntervals[i + 1] = a2;
                begin += Hx;
                
                if (i == Program.r - 1)
                    table.Rows[i].Cells[1].Value = "[" + a1 +";" + a2 +"]";
                else
                    table.Rows[i].Cells[1].Value = "[" + a1 + ";" + a2 + ")";

                table.Rows[i].Cells[2].Value = dataFrequency[i];

                dataAverage[i] = Convert.ToDouble((a2 - a1) / 2);
                table.Rows[i].Cells[3].Value = dataAverage[i];

                dataPoligon[i] = (double)dataFrequency[i] / (double)Program.N;
                table.Rows[i].Cells[4].Value = dataPoligon[i];

                dataGist[i] = dataPoligon[i] / Hx;
                table.Rows[i].Cells[5].Value = dataGist[i];

                //подсчитываем функцию распределения через сумму пред. Ni/N
                if (i == 0) 
                    table.Rows[i].Cells[6].Value = table.Rows[i].Cells[4].Value;
                else
                    table.Rows[i].Cells[6].Value = 
                        Convert.ToDouble(table.Rows[i - 1].Cells[6].Value) 
                        + Convert.ToDouble(table.Rows[i].Cells[4].Value);
                dataEmpiric[i] = Convert.ToDouble(table.Rows[i].Cells[6].Value);

            }

            //заполняем текст боксы
            textBox_Xmin.Text = String.Format("{0:0.00}", Convert.ToString(xMin));
            textBox_Xmax.Text = String.Format("{0:0.00}", Convert.ToString(xMax));
            textBox_Rx.Text = String.Format("{0:0.00}", Convert.ToString(Rx));
            textBox_r.Text = String.Format("{0:0.00}", Convert.ToString(Program.r));
            textBox_Hx.Text = String.Format("{0:0.00}", Convert.ToString(Hx));
            textBox_extend.Text = String.Format("{0:0.00}", Convert.ToString(extendX));

            
        }

        private void button_graphics_Click(object sender, EventArgs e)
        {
            //надо передать новой форме, где будут графики данные 
            //Для полигона - средние значения и dataPoligon
            //Для гистограммы - интервалы и dataGist
            //Для эмпирик функ - интервалы и dataEmpiric

            //создаем форму графика
            Graphics grph = new Graphics(2, dataIntervals, dataPoligon, dataGist, dataAverage, dataEmpiric, Hx);
            grph.ShowDialog();
        }
    }
}
