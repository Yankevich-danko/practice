using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1
{
    struct Train 
    {
       public string name;
       public int number;
       public DateTime date;

        public Train(string name, int number, DateTime date)
        {
            this.name = name;
            this.number = number;
            this.date = date;
        }

       
       
        public void raspisanie()
        {
            Console.WriteLine("Название пункта назначения " + this.name + " \nНомер поезда " + number + " \nВремя отправления" + date);
        }
    }
    
    class Program
    {
       
        static void Main(string[] args)
        {
           
            Train[] main_poezd = new Train[8];

            

            for (int i = 0; i < main_poezd.Count(); i++)
            {
                Console.WriteLine("Введите название пункта назначения:  ");
                main_poezd[i].name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Введите номер поезда: ");
                main_poezd[i].number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите дату отправления: ");
                main_poezd[i].date = Convert.ToDateTime(Console.ReadLine());

            }


            Train temp;
            for (int i = 0; i < main_poezd.Length - 1; i++)
            {
                for (int j = i + 1; j < main_poezd.Length; j++)
                {
                    if (main_poezd[i].number > main_poezd[j].number)
                    {
                        temp = main_poezd[i];
                        main_poezd[i] = main_poezd[j];
                        main_poezd[j] = temp;
                    }
                }
            }

            for (int i = 0; i < main_poezd.Length; i++)
            {
                main_poezd[i].raspisanie();
                Console.WriteLine();
            }

            string str;
            bool b = true;
            int count = 0;
            while (b)
            {
                Console.WriteLine("\n\nВведите номер поезда для поиска");
                str = Console.ReadLine();

                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]) && (Convert.ToInt32(str[i]) <= 8 || Convert.ToInt32(str[i]) >= 0))
                        count++;
                }

                if (count == str.Length)
                {
                    foreach (Train c in main_poezd)
                    {
                        if (str == c.number.ToString()) Console.WriteLine(c.ToString());
                    }
                    b = false;
                }
                else Console.WriteLine("Повторите попытку");
            }

            Console.ReadLine();
        }
    }
}
