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
        public int[] dataIntervals = new int[8];
        public double[] dataEmpiric = new double[Program.r];
        public Graphics(int value,int[] intervals, double[] poligon, double[] gist, double[] average, 
                            double[] empiric)
        {
            InitializeComponent();
            dataIntervals = intervals;
            dataPoligon = poligon;
            dataGist = gist;
            dataAverage = average;
            dataEmpiric = empiric;
            if (value == 1)
                this.Text = "Графики для группированного ряда X";
            else
                this.Text = "Графики для группированного ряда Y";
        }
    }
}
