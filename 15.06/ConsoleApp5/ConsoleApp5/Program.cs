using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public class Invoice
        {
            
            public readonly int Account;
            public readonly string Customer;
            public readonly string Provider;

            private string _article = String.Empty;
            private int _quantity;

            public string Article
            {
                get => _article;
                set => _article = value;
            }

            public int Quantity
            {
                get => _quantity;
                set => _quantity = value;
            }

            public Invoice(int account, string customer, string provider)
            {
                Account = account;
                Customer = customer;
                Provider = provider;
            }

            public Invoice(int account, string customer, string provider, string article, int quantity) : this(account, customer, provider)
            {
                _article = article;
                _quantity = quantity;
            }

            public double GetAccountWithNds(double nds = 0.3)
            {
                return Account + (Account * nds);
            }

            public void Show()
            {
                Console.WriteLine($" {Customer} заказал у {Provider} {_quantity} {_article} и выставил счет," +
                    $"\n который будет составлять {Account} без Ндс, и {GetAccountWithNds()} с Ндс");
            }
        }


            static void Main(string[] args)
            {
                Console.Write("Клиент: ");
                string client = Console.ReadLine();
                Console.Write("Поставщик: ");
                string postav = Console.ReadLine();
                Console.Write("Счет: ");
                int summa = Convert.ToInt32(Console.ReadLine());
                Console.Write("Товар: ");
                string tovar = Console.ReadLine();
                Console.Write("Количество: ");
                int k = Convert.ToInt32(Console.ReadLine());


                Invoice invoice = new Invoice(summa, client, postav, tovar, k);
                invoice.Show();

                Console.ReadKey();
            }
        
      
    }
}
