using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kierowanie_budzetem
{
    public partial class MessageForm : Form
    {
        int timemessageform = 0;

        MainForm Form1 = new MainForm();
        public MessageForm()
        {
            InitializeComponent();
            this.AddOwnedForm(Form1);
        }
        private void MessageForm_Load(object sender, EventArgs e)
        {
            //Розміщення повідомлення при будь-якому розрішені екрана в куточку
            this.Location = new Point(Screen.GetWorkingArea(this).Width - 400, 
                Screen.GetWorkingArea(this).Height - 145);

            timer1.Enabled = true;
        }

        private void MessageForm_Click(object sender, EventArgs e)
        {
            MainForm Form1 = new MainForm();
            Form1.Show();
            //Закриття другої форми
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timemessageform += 1;
            if (timemessageform == 20)
            {
                timer1.Enabled = false;
                Form1.Show();
                this.Close();
            }
        }

        private void MessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm Form1 = new MainForm();
            //Form1.notifyIcon1.Visible = true;
            Form1.ShowInTaskbar = false;
        }
    }
}
