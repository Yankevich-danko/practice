// Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера 
// с возможностью изменения числа строк и столбцов.  
// Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков. 

using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.Write("Введите количество строк: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Введите количество столбцов: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            MyMatrix matrix = new MyMatrix(a, b);
            Console.WriteLine("Введите элементы матрицы(каждый элемент с новой строки):");
            matrix.SetElement();
            Console.WriteLine();
            matrix.Matrix();
            Console.WriteLine();
            matrix.UpStrings(10);
            matrix.Matrix();
            Console.WriteLine();
            matrix.UpColumns(10);
            matrix.Matrix();
            Console.WriteLine();
            matrix.UpStringsAndColumns(2, 3);
            matrix.Matrix();
            Console.ReadKey();
        }
    }
}