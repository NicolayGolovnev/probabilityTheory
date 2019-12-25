﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Zaychik
{
    public partial class MainForm : Form
    {
        public static Calculation calc = new Calculation();
        public static double[] masX1 = new double[Program.N];
        public static double[] masY1 = new double[Program.N];
        public static double[] masX_temp = new double[Program.N];
        public static double[] masY_temp = new double[Program.N];

        public double[] databaseX = new double [Program.N];
        public double[] databaseY = new double[Program.N];

        groupedRowX form1;
        groupedRowY form2;

        public MainForm()
        {
            InitializeComponent();
            //calc.setHiA(0.05);
            //calc.Calculate();
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Текстовый документ (*.txt)|*.txt|All files (*.*)|*.*";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                string nameFile = opf.FileName;

                //обработка файла
                //заносим X и Y в массивы

                String[] Data = File.ReadAllText(nameFile).Split('\n');
                String[] st = new string[2];

                for (int i = 0; i < Data.Length && i < Program.N; i++)
                {
                    st = Data[i].Split(' ');

                    databaseX[i] = Convert.ToDouble(st[0]);
                    databaseY[i] = Convert.ToDouble(st[1]);
                }

                int k = 0;
                for (int i = 0; i < Program.N / 5; i += 2)
                    for (int j = 0; j < Program.N / 5; j++, k++)
                    {
                        if (i == 0) mainTable.Rows.Add();
                        mainTable.Rows[j].Cells[i].Value = String.Format("{0:0,0}", Convert.ToString(databaseX[k]));
                        mainTable.Rows[j].Cells[i + 1].Value = String.Format("{0:0,0}", Convert.ToString(databaseY[k]));
                    }

                    this.toolStripStatusLabel1.Text = "Файл открылся успешно";
            }
            else
                this.toolStripStatusLabel1.Text = "Файл не открылся, попробуйте еще раз!";

            form1 = new groupedRowX(databaseX);
            form2 = new groupedRowY(databaseY);
        }

        private void групированнаяРядToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1.ShowDialog();
        }

        private void групированныйРядДляYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void корреляционнаяТаблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            correlationTable form3 = new correlationTable(form1, form2);
            form3.ShowDialog();
        }
    }
}
