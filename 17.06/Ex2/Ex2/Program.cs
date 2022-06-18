using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
        public void StruktTaker()
        {
            change = "Значение изменилось";
        }

    }

    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Значение изменилось";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Значение изменилось";
        }

        static void Main(string[] args)
            {
                
                MyStruct mainStruct = new MyStruct();
                mainStruct.change = "Не изменено";
                StruktTaker(mainStruct);
               
                Console.Write("значение структуры: ");
                Console.WriteLine(mainStruct.change);

            MyClass mainClass = new MyClass();
            mainClass.change = "Не изменено";
            ClassTaker(mainClass);
                
            Console.Write("значение класса: ");
            Console.WriteLine(mainClass.change);
            
                Console.ReadKey();
            }
        
    }
}
