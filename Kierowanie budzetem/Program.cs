using System;
using System.Windows.Forms;
using System.Threading;

namespace Kierowanie_budzetem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool onlyInstance;

            Mutex mtx = new Mutex(true, "Kierowanie budzetem", out onlyInstance);

            if (onlyInstance)
                Application.Run(new MainForm());
            else
            {
                MessageBox.Show("Program jest już uruchomiony", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
