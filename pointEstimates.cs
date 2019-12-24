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
    public partial class pointEstimates : Form
    {
        public double[] database = new double[Program.N];
        
        public double[] dataAverage = new double[Program.r];
        public double[] dataFrequency = new double[Program.r];//ni
        public int Hx = new int();
        public double uAverage = new double();
        public double uAverageTwice = new double();
        public double SuTwice = new double();

        public double xAverage = new double();
        public double SxTwice = new double();
        public double Sx = new double();

        public pointEstimates()
        {
            InitializeComponent();
        }

        public pointEstimates(int type, double koef, double[] average, int hx, double[] freq)
        {
            InitializeComponent();
            if (type == 1)
                this.Text = "Точечные оценки для ряда X";
            else
                this.Text = "Точечные оценки для ряда Y";
            dataAverage = average;
            Hx = hx;
            dataFrequency = freq;

            double[] Ui = new double[Program.r];
            for (int i = 0; i < Program.r; i++)
                Ui[i] = (dataAverage[i] - koef) / (double)Hx;

            double[] UiNi = new double[Program.N];
            for (int i = 0; i < Program.r; i++)
                UiNi[i] = Ui[i] * dataFrequency[i];

            double[] UiNiTwice = new double[Program.N];
            for (int i = 0; i < Program.r; i++)
                UiNiTwice[i] = UiNi[i] * Ui[i];

            //заполнить их в табл
            // i - Ui - Ni - UiNi - UiNiTwice

            uAverage = 0;
            uAverageTwice = 0;
            for (int i = 0; i < Program.r; i++)
            {
                uAverage += UiNi[i];
                uAverageTwice += UiNiTwice[i];
            }
            uAverage /= (double)Program.N;
            uAverageTwice /= (double)Program.N;

            SuTwice = ((double)Program.N / (double)(Program.N - 1) * (uAverageTwice - uAverage * uAverage));
            //Вывести через лейблы
            //uAverage - uAverageTwice - SuTwice

            xAverage = Hx * uAverage;
            SxTwice = Hx * Hx * SuTwice;
            Sx = Math.Sqrt(SxTwice);
            //вывести эти 3 значения в лейблы
        }
    }
}
