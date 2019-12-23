using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zaychik
{
    static class Program
    {
        public const int N = 50;//count of data
        public const int r = 7;//count of interval
        public const int k = 2;//unknow number in normal distribution

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
