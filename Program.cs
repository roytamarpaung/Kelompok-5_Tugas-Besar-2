using System;
using System.Windows.Forms;

namespace APL
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //run the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //login form
            Application.Run(new LoginForm()); 
        }
    }
}