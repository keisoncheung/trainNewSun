using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using trainNewSun;

namespace trainNewSunForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login();
            //Application.Run(new FrmMain());
        }

        static void Login()
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
            if (frm.Result == true)
                Application.Run(new FrmMain());
        }
    }
}
