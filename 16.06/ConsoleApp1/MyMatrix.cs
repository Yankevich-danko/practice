﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyMatrix
    {
        private int[,] arr;
        private int strings;
        private int columns;
        public MyMatrix(int a, int b)
        {
            strings = a;
            columns = b;
            arr = new int[a, b];
        }
        public int Strings
        {

            get
            {
                return strings;
            }
        }
        public int Columns
        {

            get
            {
                return columns;
            }
        }
        public int GetElement(int x, int y)
        {
            return arr[x, y];
        }
        public void SetElement()
        {
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void Matrix()
        {
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        public void UpStrings(int x)
        {

            List<int> subarr = new List<int>();
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    subarr.Add(arr[i, j]);
                }
            }
            strings = x;
            arr = new int[strings, columns];
            int counter = 0;
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (counter < subarr.Count)
                    {
                        arr[i, j] = subarr[counter];
                        counter++;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
            }
        }
        public void UpColumns(int x)
        {
            List<int> hotiho = new List<int>();
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    hotiho.Add(arr[i, j]);
                }
            }
            columns = x;
            arr = new int[strings, columns];
            int counter = 0;
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (counter < hotiho.Count)
                    {
                        arr[i, j] = hotiho[counter];
                        counter++;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
            }
        }
        public void UpStringsAndColumns(int x, int y)
        {
            List<int> hotiho = new List<int>();
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    hotiho.Add(arr[i, j]);
                }
            }
            strings = x;
            columns = y;
            arr = new int[strings, columns];
            int counter = 0;
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (counter < hotiho.Count)
                    {
                        arr[i, j] = hotiho[counter];
                        counter++;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
            }
        }
        
    }
}

