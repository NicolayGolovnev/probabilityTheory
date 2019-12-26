
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zaychik;

namespace Zaychik
{
    public partial class HipotesyX : Form
    {
        public HipotesyX()
        {
            InitializeComponent();
        }

        public bool doY = false;

        private void HipotesyX_FormClosed(object sender, FormClosedEventArgs e)
        {
            // GlobalVars.FormHipotesyX = false;
        }

        private void Hipotesy_X_Load(object sender, EventArgs e)
        {

            /* CustomToolTip[] tip = new CustomToolTip[10];
             for (int i = 0; i < 10; i++)
                 tip[i] = new CustomToolTip();

             tip[0].SetCustomToolTip(pictureBox5, "hi_kvadr.png");
             tip[1].SetCustomToolTip(pictureBox4, "hi_kvadr.png");
             tip[2].SetCustomToolTip(pictureBox2, "kvantil.png");
             tip[3].SetCustomToolTip(pictureBox6, "laplas_X.png");
             tip[4].SetCustomToolTip(label1, "m_label.png");
             tip[5].SetCustomToolTip(label7, "a_label.png");
             tip[6].SetCustomToolTip(label2, "mk1_label.png");
             */
            if (!doY)
            {
                for (int i = 0; i < Program.r; i++)
                {
                    raspredX.Rows.Add();

                    raspredX.Rows[i].Cells[0].Value = i + 1; // i


                    if (i == Program.r - 1)
                    {
                        raspredX.Rows[i].Cells[1].Value = "[" + MainForm.calc.inter_X[i].getF() + ";" + "+∞" + ")";
                    }
                    else
                        if (i == 0)
                    {
                        raspredX.Rows[i].Cells[1].Value = "(" + "-∞" + ";" + MainForm.calc.inter_X[i].getS() + ")"; //interval
                    }
                    else
                        raspredX.Rows[i].Cells[1].Value = "[" + MainForm.calc.inter_X[i].getF() + ";" + MainForm.calc.inter_X[i].getS() + ")";

                    raspredX.Rows[i].Cells[2].Value = MainForm.calc.inter_X[i].getN(); //Ni

                    raspredX.Rows[i].Cells[3].Value = String.Format("{0:0.00}", MainForm.calc.norm_vel_X[i]); // Zi

                    raspredX.Rows[i].Cells[4].Value = String.Format("{0:0.000}", MainForm.calc.form_lap_X[i]); // laplac

                    raspredX.Rows[i].Cells[5].Value = String.Format("{0:0.000}", MainForm.calc.ver_sob_X[i]); // pi     

                    raspredX.Rows[i].Cells[6].Value = String.Format("{0:0.00}", MainForm.calc.teor_chast_X[i]); // answ

                    raspredX.Rows[i].Cells[7].Value = "↓";

                }

                int k = 0;
                int j = 0;

                int[,] masdef = new int[5, 7];
                int[] answ = new int[5];
                // raspredInitX.Rows[i].Cells[0].Value = (k + 1).ToString();
                for (int i = 0; i < MainForm.calc.d_X; i++)
                {
                    int p = 0;
                    //raspredInitX.Rows.Add();
                    masdef[i, p++] = k;
                    char count = MainForm.calc.flags_X[k];
                    char step = (char)1;
                    //raspredInitX.Rows[i].Cells[0].Value = (k + 1).ToString();

                    while (count != 0)
                    {
                        masdef[i, p++] = k + step++;
                        count--;
                    }
                    k += step;
                    // j++;
                }


                for (int i = 0; i < 5; i++)
                {
                    for (int t = 0; t < 6; t++)
                    {
                        // if ((masdef[i,t] != 0)&& (masdef[i,t+1] == 0))
                        if (masdef[i, t + 1] == 0)
                        {
                            answ[i] = masdef[i, t];
                            break;
                        }
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    raspredX.Rows[answ[i]].Cells[7].Value = String.Format("{0:0.00}", MainForm.calc.dlya_stat_X[i]);

                }

                //лэйблы

                label8.Text = Convert.ToString(MainForm.calc.d_X);
                label7.Text = Convert.ToString(MainForm.calc.step_svobodi_X);
                label6.Text = String.Format("{0:0.00}", MainForm.calc.hi_vib_X);
                //hi_vivod.Text = String.Format("{0:0.00}", MainForm.calc.hi_vib_X);
                label10.Text = String.Format("{0:0.00}", MainForm.calc.quant_hi_X);
                //svoboda.Text = "(" + Convert.ToString(MainForm.calc.step_svobodi_X) + ") =";
                label5.Text = Convert.ToString(1 - MainForm.calc.hi_a);
                //textBox1.Text = Convert.ToString(MainForm.calc.hi_a);

                double a1 = MainForm.calc.hi_vib_X;
                double a2 = MainForm.calc.quant_hi_X;
                if (a1 < a2)
                {
                    label11.Text = "Так как " + label6.Text + " < " + label10.Text + " , то гипотеза H(0)";
                    label13.Text = "не противоречит выборным данным";
                }
                else
                {
                    label11.Text = "Так как " + label6.Text + " > " + label10.Text + " , то гипотеза H(0)";
                    label13.Text = "противоречит выборным данным";
                }
                label12.Text = "о нормальном распределении величины X";

            }
            else {
                for (int i = 0; i < Program.r; i++)
                {
                    raspredX.Rows.Add();

                    raspredX.Rows[i].Cells[0].Value = i + 1; // i


                    if (i == Program.r - 1)
                    {
                        raspredX.Rows[i].Cells[1].Value = "[" + MainForm.calc.inter_Y[i].getF() + ";" + "+∞" + ")";
                    }
                    else
                        if (i == 0)
                    {
                        raspredX.Rows[i].Cells[1].Value = "(" + "-∞" + ";" + MainForm.calc.inter_Y[i].getS() + ")"; //interval
                    }
                    else
                        raspredX.Rows[i].Cells[1].Value = "[" + MainForm.calc.inter_Y[i].getF() + ";" + MainForm.calc.inter_Y[i].getS() + ")";

                    raspredX.Rows[i].Cells[2].Value = MainForm.calc.inter_Y[i].getN(); //Ni

                    raspredX.Rows[i].Cells[3].Value = String.Format("{0:0.00}", MainForm.calc.norm_vel_Y[i]); // Zi

                    raspredX.Rows[i].Cells[4].Value = String.Format("{0:0.000}", MainForm.calc.form_lap_Y[i]); // laplac

                    raspredX.Rows[i].Cells[5].Value = String.Format("{0:0.000}", MainForm.calc.ver_sob_Y[i]); // pi     

                    raspredX.Rows[i].Cells[6].Value = String.Format("{0:0.00}", MainForm.calc.teor_chast_Y[i]); // answ

                    raspredX.Rows[i].Cells[7].Value = "↓";

                }

                int k = 0;
                int j = 0;

                int[,] masdef = new int[5, 7];
                int[] answ = new int[5];
                // raspredInitX.Rows[i].Cells[0].Value = (k + 1).ToString();
                for (int i = 0; i < MainForm.calc.d_Y; i++)
                {
                    int p = 0;
                    //raspredInitX.Rows.Add();
                    masdef[i, p++] = k;
                    char count = MainForm.calc.flags_Y[k];
                    char step = (char)1;
                    //raspredInitX.Rows[i].Cells[0].Value = (k + 1).ToString();

                    while (count != 0)
                    {
                        masdef[i, p++] = k + step++;
                        count--;
                    }
                    k += step;
                    // j++;
                }


                for (int i = 0; i < 5; i++)
                {
                    for (int t = 0; t < 6; t++)
                    {
                        // if ((masdef[i,t] != 0)&& (masdef[i,t+1] == 0))
                        if (masdef[i, t + 1] == 0)
                        {
                            answ[i] = masdef[i, t];
                            break;
                        }
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    raspredX.Rows[answ[i]].Cells[7].Value = String.Format("{0:0.00}", MainForm.calc.dlya_stat_Y[i]);

                }

                //лэйблы
                label2.Text = "Y^2 =";
                label3.Text = "Yв^2 = ";
                label9.Text = "Y(0.95)^2 = ";
                label8.Text = Convert.ToString(MainForm.calc.d_Y);
                label7.Text = Convert.ToString(MainForm.calc.step_svobodi_Y);
                label6.Text = String.Format("{0:0.00}", MainForm.calc.hi_vib_Y);
                //hi_vivod.Text = String.Format("{0:0.00}", MainForm.calc.hi_vib_X);
                label10.Text = String.Format("{0:0.00}", MainForm.calc.quant_hi_Y);
                //svoboda.Text = "(" + Convert.ToString(MainForm.calc.step_svobodi_X) + ") =";
                label5.Text = Convert.ToString(1 - MainForm.calc.hi_a);
                //textBox1.Text = Convert.ToString(MainForm.calc.hi_a);

                double a1 = MainForm.calc.hi_vib_X;
                double a2 = MainForm.calc.quant_hi_X;
                if (a1 < a2)
                {
                    label11.Text = "Так как " + label6.Text + " < " + label10.Text + " , то гипотеза H(0)";
                    label13.Text = "не противоречит выборным данным";
                }
                else
                {
                    label11.Text = "Так как " + label6.Text + " > " + label10.Text + " , то гипотеза H(0)";
                    label13.Text = "противоречит выборным данным";
                }
                label12.Text = "о нормальном распределении величины X";


            }
        }
    }
}