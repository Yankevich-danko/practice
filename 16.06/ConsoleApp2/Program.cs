using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class Article
    {
        private int _index;
        private string _name;
        private string _storeName;
        private decimal _price;

        public int Index => _index;
        public string Name => _name;

        public string StoreName => _storeName;

        public decimal Price => _price;

        public Article(int index, string name, string storeName, decimal price)
        {
            _index = index;
            _name = name;
            _storeName = storeName;
            _price = price;
        }

        public static decimal operator +(Article right, Article left)
        {
            var price = right.Price + left.Price;
            return price;
        }
    }

    public class Store
    {
        private List<Article> _goods;

        public Article this[int index] => _goods.FirstOrDefault(g => g.Index.Equals(index));

      //  public Good this[string name] => _goods.FirstOrDefault(g => g.Name.Equals(name));

        public Store()
        {
            _goods = new List<Article>();
        }

        public void AddGood(Article good)
        {
            _goods.Add(good);
        }

        public void SortByIndex()
        {
            _goods = _goods.OrderBy(g => g.Index).ToList();
        }
        public void SortByPrice()
        {
            _goods = _goods.OrderBy(g => g.Price).ToList();
        }

        public void SortByName()
        {
            _goods = _goods.OrderBy(g => g.Name).ToList();
        }

        public void SortByStoreName()
        {
            _goods = _goods.OrderBy(g => g.StoreName).ToList();
        }
    }
    class Program
    {
        private static bool _insertMode = true;
        private static Store _stock;

        static void Main(string[] args)
        {
            _stock = new Store();

            while (_insertMode)
            {
                try
                {
                    Console.Write("Введите индекс товара:");
                    var index = Console.ReadLine();
                    Console.Write("Введите название товара:");
                    var name = Console.ReadLine();
                    Console.Write("Введите название магазина:");
                    var storeName = Console.ReadLine();
                    Console.Write("Введите стоимость товара:");
                    var price = decimal.Parse(Console.ReadLine());

                    var good = new Article(Convert.ToInt32(index), name, storeName, price);
                    _stock.AddGood(good);
                }
                catch (Exception e)
                { 
                    Console.WriteLine("Ошибка ввода");
                }


                var answer = new ConsoleKeyInfo();
                while (answer.Key != ConsoleKey.Y)
                {
                    if (answer.Key == ConsoleKey.N)
                    {
                        _insertMode = false;
                        break;
                    }

                    Console.Write("Добавить еще один товар? (y - да, n - нет):");
                    answer = Console.ReadKey();
                    Console.WriteLine();
                }
            }

            Console.Write("Введите индекс товара для поиска:");
            var Findindex = Console.ReadLine();

            var foundGood = _stock[Convert.ToInt32(Findindex)];
            Console.WriteLine(foundGood == null ? "Такого товара нет" : $"{foundGood.Index},{foundGood.Name}, {foundGood.Price}, {foundGood.StoreName}");

            Console.ReadLine();
        }
    }
}
