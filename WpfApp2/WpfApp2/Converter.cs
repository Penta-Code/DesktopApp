using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp2
{
    class Converter
    {
        double usd, eur, rub;

        public double Usd { get { return usd; } }
        public double Eur { get { return eur; } }
        public double Rub { get { return rub; } }
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double BuyUSD(int summ)
        {
            double result = summ / usd;
            return result;
            //Console.WriteLine($"\nYou have bought {result} dollars");
        }

        public double SellUSD(int summ)
        {
            double result = usd * summ;
            return result;
            //Console.WriteLine($"You have sold {summ} dollars and got {result} soms");
        }

        public double BuyEUR(int summ)
        {
            double result = summ / eur;
            return result;
            //Console.WriteLine($"\nYou have bought {result} euros");
        }

        public double SellEUR(int summ)
        {
            double result = eur * summ;
            return result;
            //Console.WriteLine($"You have sold {summ} euros and got {result} soms");
        }

        public double BuyRUB(int summ)
        {
            double result = summ / rub;
            return result;
            //Console.WriteLine($"\nYou have bought {result} rubles");
        }

        public double SellRUB(int summ)
        {
            double result = rub * summ;
            return result;
            //Console.WriteLine($"You have sold {summ} rubles and got {result} soms");
        }

        public override string ToString()
        {
            return $"USD = {usd}\nEUR = {eur}\nRUB = {rub}";
        }
    }
}
