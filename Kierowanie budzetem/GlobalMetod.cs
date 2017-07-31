using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Kierowanie_budzetem
{
    public static class GlobalMetod
    {
        public static bool startup_true_or_false;
        //Визначає чи є автозагрузка
        public static void StartUp_True_False()
        {
            //GetValue шукає в автозагрузці програму і передає в value адресу до проги
            //Якщо не знаходить, то value = null
            RegistryKey reg = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            String value = (String)reg.GetValue("Kierowanie budzetem");

            if (!String.IsNullOrEmpty(value))
            {
                startup_true_or_false = true;
            }
            else
            {
                startup_true_or_false = false;
            }
        }


        //Знаходимо кількість днів
        public static int NumberOfDays(DateTime min, DateTime max)
        {
            //DateTime i = Convert.ToDateTime();
            string minusdata;
            if (min.Date < DateTime.Now.Date && max.Date >= DateTime.Now.Date)
                minusdata = Convert.ToString(max.Date - DateTime.Now.Date);
            else
                minusdata = Convert.ToString(max.Date - min.Date);
            //Якщо сьогоднішня дата = максимальній даті
            if (minusdata == "00:00:00")
                return 1;
            //Розділяє дату по кожній кнопці і записує в масив
            string[] mas = minusdata.Split('.');
            return (Convert.ToInt32(mas[0]) + 1);
        }

        //Підраховуємо скільки грошей залишилося
        public static double Is_Money(double income, double residence,
            double other_expenses, double spent)
        {
            return income - residence - other_expenses - spent;
        }
    }
}
