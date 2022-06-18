using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public enum Employees
    {
        ChiefExecutiveOfficer = 140,
        ChiefTechnologyOfficer = 130,
        JuniorDeveloper = 50,
        MiddleDeveloper = 70,
        SeniorDeveloper = 90,
        QualityAssuranceEngineers = 110
    }

    public  class Accauntant
    {
       

        public static bool AskForBonus(Employees postWorker, int hours)
        {
            if (hours >= (int)postWorker)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите количество часов: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выберете должность(1 - JuniorDeveloper; 2 - MiddleDeveloper; 3 - SeniorDeveloper; 4 - QualityAssuranceEngineers;  5 - ChiefTechnologyOfficer; 6 - ChiefExecutiveOfficer): ");
            int d = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
               
                case 1:
                    if (Accauntant.AskForBonus(Employees.JuniorDeveloper, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена. В другой раз");
                    break;
                case 2:
                    if (Accauntant.AskForBonus(Employees.MiddleDeveloper, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена. В другой раз");
                    break;
                case 3:
                    if (Accauntant.AskForBonus(Employees.SeniorDeveloper, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена. В другой раз");
                    break;
                case 4:
                    if (Accauntant.AskForBonus(Employees.QualityAssuranceEngineers, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена. В другой раз");
                    break;
                case 5:
                    if (Accauntant.AskForBonus(Employees.ChiefTechnologyOfficer, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена. В другой раз");
                    break;
                case 6:
                    if (Accauntant.AskForBonus(Employees.ChiefExecutiveOfficer, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена. В другой раз");
                    break;
                default:
                    Console.WriteLine("Такого сотрудника нет");
                    break;

            }
           
            Console.ReadKey();
        }
    }
}
