using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrthopedicClinic
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Authoriz start = new Authoriz();
            Application.Run(start);
            //Form1 f = new Form1();
            //f.stat = 1;
            //Application.Run(f);            
            ////Application.Run(new Form1());
        }

    }
}
