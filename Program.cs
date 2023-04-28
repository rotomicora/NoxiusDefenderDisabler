using System;
using System.Windows.Forms;

/*
---------------------------------------------------
            NOXIUS DEFENDER DISABLER
---------------------------------------------------
           Developed by rotomicora#0001
---------------------------------------------------
            https://discord.gg/noxius
---------------------------------------------------
*/

namespace NoxiusDefenderDisabler
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
