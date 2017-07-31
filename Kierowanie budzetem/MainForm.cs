using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace Kierowanie_budzetem
{
    public partial class MainForm : Form
    {
        public double income, residence, other_expenses, spent;

        //Дозвіл збереження в реєстр(автозагрузка)
        RegistryKey reg = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        //Файл, де будуть зберігатися наші налашування
        FileInfo file = new FileInfo(Application.StartupPath + "Settings.txt");

        //Для дозволу введення тільки 2 знаків після коми
        //Кількість знаків після коми
        int number_of_decimal_places = 0;
        //Чи в текстбоксі є кома?
        bool yes_no_places = false;


        //Дозвіл закриття програми
        bool exit_application = false;

        //Змінні, для коректного відображення дат в DateTimePick
        int year_now = DateTime.Now.Year;
        int month_now = DateTime.Now.Month;
        int day_now = DateTime.Now.Day;

        public MainForm()
        {
            InitializeComponent();
        }
//_____________________________________StartUpWithWindows_____________________________________
        //Добавляєм на автозагрузку
        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Якщо програми ще нема в автозагрузці
            if (!GlobalMetod.startup_true_or_false)
            {
                //Application.ExecutablePath - вказує путь до exe програми
                //SetValue("Назва програми","Путь до exe програми")
                reg.SetValue("Kierowanie budzetem", Application.ExecutablePath.ToString());
                //Встановлення галочки в меню
                yesToolStripMenuItem.Checked = true;
                noToolStripMenuItem.Checked = false;
                GlobalMetod.StartUp_True_False();
            }
        }

        //Видалення з автозагрузки
        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Якщо програма є в автозагрузці
            if (GlobalMetod.startup_true_or_false)
            {
                //Видалення з автозагрузки
                reg.DeleteValue("Kierowanie budzetem");
                //Встановлення галочки в меню
                yesToolStripMenuItem.Checked = false;
                noToolStripMenuItem.Checked = true;
                GlobalMetod.StartUp_True_False();
            }
        }







        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
        }

        //Закриваємо нашу програму
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            exit_application = true;
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileInfo file = new FileInfo(Application.StartupPath +"Settings.txt");
            //Не даємо закрити програму
            if (!exit_application)
            {
                e.Cancel = true;
                this.Hide();
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
                if (file.Exists == false)
                {
                    notifyIcon1.BalloonTipText = "Wprowadź swój dochód!";
                    notifyIcon1.ShowBalloonTip(10000);
                }
                else
                {
                    notifyIcon1.BalloonTipText = "Budżet na dziś: " + Math.Round(
                        (GlobalMetod.Is_Money(income, residence, other_expenses, spent)
                        / GlobalMetod.NumberOfDays(StartData.Value, FinishData.Value)), 2);
                    notifyIcon1.ShowBalloonTip(10000);
                }
            }
            //Ну ладно, нехай вже закривається
            else e.Cancel = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(Application.StartupPath + "Settings.txt");
            //Визначення чи є автозагрузка
            //Якщо є, то глобальна змінна startup_true_or_false=true
            GlobalMetod.StartUp_True_False();

            FileExistTrueFalse();

            if (GlobalMetod.startup_true_or_false)
            {
                this.Hide();
                yesToolStripMenuItem.Checked = true;
                noToolStripMenuItem.Checked = false;
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;

                FormHide();
            }
            else
            {
                yesToolStripMenuItem.Checked = false;
                noToolStripMenuItem.Checked = true;
                notifyIcon1.Visible = false;
                this.ShowInTaskbar = true;
                FormHide();
            }
            if (tabControl1.SelectedTab == MinusMoneyPage)
            {
                timer1.Enabled = true;
            }
        }

        public void FormHide()
        {
            FileInfo file = new FileInfo(Application.StartupPath + "Settings.txt");
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = false;
            if (file.Exists == false)
            {
                notifyIcon1.BalloonTipText = "Wprowadź swój dochód!";
                notifyIcon1.ShowBalloonTip(10000);
            }
            else
            {
                notifyIcon1.BalloonTipText = "Budżet na dziś: " + Math.Round(
                    (GlobalMetod.Is_Money(income, residence, other_expenses, spent)
                    / GlobalMetod.NumberOfDays(StartData.Value, FinishData.Value)), 2);
                notifyIcon1.ShowBalloonTip(10000);
            }
        }

        public void FileExistTrueFalse()
        {
            FileInfo file = new FileInfo(Application.StartupPath + "Settings.txt");
            if (file.Exists)
            {
                //Зчитування налаштувань з файлу
                StreamReader read_setting = new StreamReader(Application.StartupPath + "Settings.txt");
                StartData.Text = read_setting.ReadLine();
                FinishData.Text = read_setting.ReadLine();
                IncomeTextBox.Text = read_setting.ReadLine();
                ResidenceTextBox.Text = read_setting.ReadLine();
                OtherExpensesTextBox.Text = read_setting.ReadLine();
                income = Convert.ToDouble(IncomeTextBox.Text);
                if (ResidenceTextBox.Text != "")
                    residence = Convert.ToDouble(ResidenceTextBox.Text);
                if (OtherExpensesTextBox.Text != "")
                    other_expenses = Convert.ToDouble(OtherExpensesTextBox.Text);

                TextBox_True_False(true);

                while (!read_setting.EndOfStream)
                {
                    spent = Convert.ToDouble(read_setting.ReadLine());
                }
                read_setting.Close();

                GlobalMetod.NumberOfDays(StartData.Value, FinishData.Value);
                FormUpdate();

                notifyIcon1.BalloonTipText = "Budżet na dziś: " + Math.Round(
                    (GlobalMetod.Is_Money(income, residence, other_expenses, spent)
                    / GlobalMetod.NumberOfDays(StartData.Value, FinishData.Value)), 2);
                notifyIcon1.ShowBalloonTip(10000);
            }
            else
            {
                tabControl1.SelectTab(InputDataPage);
                //При старті програми, якщо немає збережених налаштувань,
                //то буде братися поточний місяць
                StartData.Value = new DateTime(year_now, month_now, 01);
                FinishData.Value = new DateTime(year_now, month_now,
                    DateTime.DaysInMonth(year_now, month_now));
                notifyIcon1.BalloonTipText = "Wprowadź swój dochód!";
                notifyIcon1.ShowBalloonTip(10000);
            }
        }

        //Введення витрат
        private void OK_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(Application.StartupPath + "Settings.txt");
            spent += Convert.ToDouble(SpentTextBox.Text);
            SpentTextBox.Clear();

            StreamWriter write_setting;
            write_setting = file.AppendText();
            write_setting.WriteLine(spent);
            write_setting.Close();

            FormUpdate();
        }



//__________________________________TextBox___________________________________________________

        //Заміна "0"-"0,"   ","-"0,"
        private void TB_TextChanged(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            if (TB.Text == "," | TB.Text == "0")
            {
                TB.Text = "0,";
                yes_no_places = true;
                number_of_decimal_places = 0;
            }
            TB.Select(TB.Text.Length, 0);
        }


        //Заборона вводу в текстбокс букв і знаків, крім ","
        private void TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TB = (TextBox)sender;
            //заміна "." на ","
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            //Перевірка чи є кома
            if (TB.Text.IndexOf(",") == -1)
            {
                yes_no_places = false;
                number_of_decimal_places = 0;
            }
            else
                yes_no_places = true;
            //якщо нажата кнопка є числом, то число записується
            //8-backspace
            //також заборонено вводити 2 коми
            //максимальне число знаків після коми - 2
            if (Char.IsNumber(e.KeyChar) && number_of_decimal_places < 2)
            {
                if (yes_no_places)
                    number_of_decimal_places++;
                return;
            }
            else if (e.KeyChar == 8)
            {
                //Баг1_виправлено - тепер можливо стирати "0,"
                if (TB.Text == "0,")
                {
                    TB.Text = ""; yes_no_places = false; number_of_decimal_places = 0;
                }
                else if (TB.Text.IndexOf(",") != -1 && number_of_decimal_places > 0)
                {
                    number_of_decimal_places--;
                }
                return;
            }
            else if (e.KeyChar == ',' && TB.Text.IndexOf(",") == -1)
            {
                yes_no_places = true;
                return;
            }
            else
                e.Handled = true;
        }

        //Блокування/розблокування вводу в текстбокси і дати
        public void TextBox_True_False(bool k)
        {
            IncomeTextBox.ReadOnly = k;
            ResidenceTextBox.ReadOnly = k;
            OtherExpensesTextBox.ReadOnly = k;
            StartData.Enabled = !k;
            FinishData.Enabled = !k;
            if (k == true)
                SaveChangeButton.Text = "Zmienić";
            else SaveChangeButton.Text = "Zapisz";
        }




        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(Application.StartupPath + "Settings.txt");
            if (StartData.Value < FinishData.Value)
            {
                if (IncomeTextBox.Text != "")
                {
                    if (SaveChangeButton.Text == "Zmienić")
                    {
                        TextBox_True_False(false);
                    }
                    else
                    {
                        //Запис налаштувань в файл
                        StreamWriter write_setting = file.CreateText();
                        //Дописуємо інфу в файл
                        write_setting.WriteLine(StartData.Value);
                        write_setting.WriteLine(FinishData.Value);
                        write_setting.WriteLine(IncomeTextBox.Text);
                        write_setting.WriteLine(ResidenceTextBox.Text);
                        write_setting.WriteLine(OtherExpensesTextBox.Text);
                        // Закриваємо файл
                        write_setting.Close();


                        income = Convert.ToDouble(IncomeTextBox.Text);
                        if (ResidenceTextBox.Text != "")
                            residence = Convert.ToDouble(ResidenceTextBox.Text);
                        if (OtherExpensesTextBox.Text != "")
                            other_expenses = Convert.ToDouble(OtherExpensesTextBox.Text);

                        TextBox_True_False(true);

                        notifyIcon1.BalloonTipText = "Budżet na jutro: " + Math.Round(
                            (GlobalMetod.Is_Money(income, residence, other_expenses, spent)
                            / GlobalMetod.NumberOfDays(StartData.Value, FinishData.Value)), 2);

                        GlobalMetod.NumberOfDays(StartData.Value, FinishData.Value);
                        FormUpdate();
                    }
                }
                else MessageBox.Show("Wprowadź swój dochód!", "Error");
            }
            else MessageBox.Show("Sprawdź datę!", "Error");
        }

        public void FormUpdate()
        {
            double ismoney = GlobalMetod.Is_Money(income, residence, other_expenses, spent);
            label3.Text = "Budżet na dziś: " + Math.Round(
                (ismoney / GlobalMetod.NumberOfDays(StartData.Value, FinishData.Value)), 2);
            label2.Text = "Pozostało pieniędzy: " + ismoney;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            FileInfo file = new FileInfo(Application.StartupPath + "Settings.txt");
            if (file.Exists == false)
                if (e.TabPage == MinusMoneyPage)
                {
                    //Відміна переходу
                    e.Cancel = true;
                    MessageBox.Show("Wprowadź dane!", "Error");
                }
                
            if (e.TabPage == MinusMoneyPage)
            {
                timer1.Enabled = true;
            }
            else timer1.Enabled = false;
        }

        private void usunąćWszystkieDaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(Application.StartupPath + "Settings.txt");
            if (file.Exists == true)
            {
                file.Delete();
                TextBox_True_False(false);
                IncomeTextBox.Clear();
                ResidenceTextBox.Clear();
                OtherExpensesTextBox.Clear();
                income = 0; residence = 0; other_expenses = 0; spent = 0;
                tabControl1.SelectTab(InputDataPage);
                notifyIcon1.BalloonTipText = "Wprowadź swój dochód!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SpentTextBox.Text != "")
                OKButton.Visible = true;
            else OKButton.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit_application = true;
            this.Close();
        }
    }
}
