using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Program
    {
        static void SortAscending(int[] intArray)
        {
            int indx; 
            for (int i = 0; i < intArray.Length; i++) 
            {
                indx = i; 
                for (int j = i; j < intArray.Length; j++) 
                {
                    if (intArray[j] < intArray[indx])
                    {
                        indx = j; 
                    }
                }
                if (intArray[indx] == intArray[i]) 
                    continue;
                
                int temp = intArray[i]; 
                intArray[i] = intArray[indx];
                intArray[indx] = temp;
            }
        }
        static void Main(string[] args)
        {
            
            int[] a = new int[5] { 2, 4, 5, 1, 4 };
            Console.WriteLine(" Текущий массив: ");
            for (int i = 0; i < a.Length; i++)
                Console.Write(" " + a[i]);
            Console.WriteLine(" ");
            Console.WriteLine(" отсортированный массив: ");
            SortAscending(a); 
           
          
          
            foreach (int i in a)
                Console.Write($"{i} ");
            Console.ReadKey();
        }
    }
}
