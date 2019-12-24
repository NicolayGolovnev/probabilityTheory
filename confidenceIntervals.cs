using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zaychik
{
    public partial class confidenceIntervals : Form
    {
        public double y = new double();
        public double a = new double();
        double[] M = new double[2];
        double[] D = new double[2];

        public double getQuantStud(double p, int k)
        {
            int index_p;
            if (p <= 0.55)
                index_p = 0;
            else if (p <= 0.60)
                index_p = 1;
            else if (p <= 0.65)
                index_p = 2;
            else if (p <= 0.7)
                index_p = 3;
            else if (p <= 0.75)
                index_p = 4;
            else if (p <= 0.8)
                index_p = 5;
            else if (p <= 0.85)
                index_p = 6;
            else if (p <= 0.9)
                index_p = 7;
            else if (p <= 0.95)
                index_p = 8;
            else if (p <= 0.975)
                index_p = 9;
            else if (p <= 0.99)
                index_p = 10;
            else if (p <= 0.995)
                index_p = 11;
            else if (p <= 0.9975)
                index_p = 12;
            else if (p <= 0.999)
                index_p = 13;
            else
                index_p = 14;


            using (FileStream fstream1 = File.OpenRead("tableQuantStud.txt"))
            {
                // преобразуем строку в байты 
                byte[] array = new byte[fstream1.Length];
                // считываем данные 
                fstream1.Read(array, 0, array.Length);
                // декодируем байты в строку 
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                string[] s = textFromFile.Split('\n');
                string[] s1 = s[k - 1].Split('\t');
                string chislo = s1[index_p];
                double x = Convert.ToDouble(chislo);
                return x;
            }
        }

        public double getQuant(int k, double p)
        {
            int index_p = 0;
            if (p <= 0.005)
                index_p = 0;
            else if (p <= 0.01)
                index_p = 1;
            else if (p <= 0.025)
                index_p = 2;
            else if (p <= 0.05)
                index_p = 3;
            else if (p <= 0.1)
                index_p = 4;
            else if (p <= 0.9)
                index_p = 5;
            else if (p <= 0.95)
                index_p = 6;
            else if (p <= 0.975)
                index_p = 7;
            else if (p <= 0.99)
                index_p = 8;
            else if (p <= 0.995)
                index_p = 9;

            if (k > 30 && k < 35)
                k = 30;
            else if (k > 35 && k < 40)
                k = 31;
            else if (k > 40 && k < 45)
                k = 32;
            else if (k > 45 && k < 50)
                k = 33;
            else if (k > 50 && k < 75)
                k = 34;
            else if (k > 75 && k < 100)
                k = 35;
            else
                k = 1;

            using (FileStream fstream = File.OpenRead("tableQuant.txt"))
            {
                // преобразуем строку в байты 
                byte[] array = new byte[fstream.Length];
                // считываем данные 
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку 
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                string[] s = textFromFile.Split('\n');
                string[] s1 = s[k - 1].Split(' ');
                double x = Convert.ToDouble(s1[index_p]);
                return x;
            }
        }
        public confidenceIntervals()
        {
            InitializeComponent();
        }

        public confidenceIntervals(int type, pointEstimates p)
        {
            InitializeComponent();
            y = 0.95;
            a = 1 - y;
            label2.Text = Convert.ToString(y);
            label4.Text = Convert.ToString(a);

            if (type == 1)
            {
                label6.Text = "< M(X) <";
                label9.Text = "< D(X) <";
            }
            else
            {
                label6.Text = "< M(Y) <";
                label9.Text = "< D(Y) <";
            }

            
            M[0] = p.xAverage - ((p.Sx / Math.Sqrt(Program.N)) * getQuantStud(1 - a / 2, Program.N - 1));
            M[1] = p.xAverage + ((p.Sx / Math.Sqrt(Program.N)) * getQuantStud(1 - a / 2, Program.N - 1));
            
            label5.Text = String.Format("{0:0.00}", M[0]);
            label7.Text = String.Format("{0:0.00}", M[1]);

            D[0] = ((Program.N - 1) * p.SxTwice) / getQuant(Program.N - 1, 1 - (a / 2));
            D[1] = ((Program.N - 1) * p.SxTwice) / getQuant(Program.N - 1, (a / 2));
            label8.Text = String.Format("{0:0.00}", D[0]);
            label10.Text = String.Format("{0:0.00}", D[1]);
        }

    }
}
