using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._4
{
    class Program
    {
        static List<string> FCs = new List<string>();
        static List<string> post = new List<string>();

        static void AddNewDossier()
        {
            Console.Write("\nВведите ФИО сотрудника: ");
            FCs.Add(Console.ReadLine());
            Console.Write("Введите должность сотрудника: ");
            post.Add(Console.ReadLine());
            Console.Write("Сотрудник добавлен!");
        }

        static void OutputAllDossier()
        {
            for (int i = 0; i < FCs.Count; i++)
                Console.WriteLine("\n{0} - " + FCs[i] + " - " + post[i], i + 1);
        }

        static void DeleteDossier()
        {
            Console.Write("Введите номер досье: ");
            try
            {
                FCs.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
                Console.WriteLine("\nДосье удалено!");
            }
            catch
            {
                Console.WriteLine("\nТакого номера нет!");
            }
        }

        static void FindDossier()
        {
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            int index = -1;
            for (int i = 0; i < FCs.Count; i++)
            {
                if (FCs[i].Substring(0, surname.Length) == surname)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
                Console.WriteLine("\n{0} - " + FCs[index] + " - " + post[index], index + 1);
            else
                Console.WriteLine("\nЧеловека с такой фамилией нет!");

        }
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n1. Добавить досье\n2. Вывести все досье\n3. Удалить досье\n4. Поиск по фамилии\n5. Выход");
                Console.Write("Выберите действие: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        AddNewDossier();
                        break;
                    case "2":
                        OutputAllDossier();
                        break;
                    case "3":
                        DeleteDossier();
                        break;
                    case "4":
                        FindDossier();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный номер");
                        break;
                }
            }
        }
    }
}
