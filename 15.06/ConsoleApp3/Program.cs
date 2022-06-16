using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Converter
    {
        double usd;
        double eur;
        double rub;
        double uah;

        public double Usd
        { get { return usd; } }
        public double Eur
        { get { return eur; } }
        public double Rub
        { get { return rub; } }
        public double Uah
        { get { return uah; } }
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;

        }

        public Converter(double uah)
        {
            this.uah = uah;
        }

        public double fromUsdToUah()
        {
            return usd * 0.033979;
        }

        public double fromEurToUah()
        {
            return eur * 0.032743;
        }

        public double fromRubToUah()
        {
            return rub * 1.94;
        }

        public double fromUahToUsd()
        {
            return uah * 30;
        }

        public double fromUahToEur()
        {
            return uah * 31;
        }

        public double fromUahToRub()
        {
            return uah * 0.51535;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(100, 80, 300);

            Console.WriteLine("{0} usd = {1} uah ", converter.Usd, converter.fromUsdToUah());
            Console.WriteLine("{0} eur = {1} uah ", converter.Eur, converter.fromEurToUah());
            Console.WriteLine("{0} rub = {1} uah ", converter.Rub, converter.fromRubToUah());

            Converter reversconvertor = new Converter(100);

            Console.WriteLine(new string('-', 40));

            Console.WriteLine("{0} uah = {1} usd", reversconvertor.Uah, reversconvertor.fromUahToUsd());
            Console.WriteLine("{0} uah = {1} eur", reversconvertor.Uah, reversconvertor.fromUahToEur());
            Console.WriteLine("{0} uah = {1} rub", reversconvertor.Uah, reversconvertor.fromUahToRub());
            Console.ReadKey();
        }
    }
}
