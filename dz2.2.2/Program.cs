using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2._2._2


    
    {
        class Program
        {
            static void Main(string[] args)
            {
                Converter converter = new Converter(27.5, 32.0, 0.35);

                Console.WriteLine("1. Convert from UAH");
                Console.WriteLine("2. Convert to UAH");
                Console.WriteLine("Enter your choice:");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter UAH amount:");
                        double.TryParse(Console.ReadLine(), out double uah);
                        Console.WriteLine("USD amount: " + converter.ConvertToUsd(uah));
                        Console.WriteLine("EUR amount: " + converter.ConvertToEur(uah));
                        Console.WriteLine("RUB amount: " + converter.ConvertToRub(uah));
                        break;
                    case 2:
                        Console.WriteLine("Enter USD amount:");
                        double.TryParse(Console.ReadLine(), out double usd);
                        Console.WriteLine("UAH amount: " + converter.ConvertFromUsd(usd));
                        Console.WriteLine("Enter EUR amount:");
                        double.TryParse(Console.ReadLine(), out double eur);
                        Console.WriteLine("UAH amount: " + converter.ConvertFromEur(eur));
                        Console.WriteLine("Enter RUB amount:");
                        double.TryParse(Console.ReadLine(), out double rub);
                        Console.WriteLine("UAH amount: " + converter.ConvertFromRub(rub));
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
                Console.ReadKey();
            }
        }
        class Converter
        {
            private double usd;
            private double eur;
            private double rub;

            public Converter(double usd, double eur, double rub)
            {
                this.usd = usd;
                this.eur = eur;
                this.rub = rub;
            }

            public double ConvertToUsd(double uah)
            {
                return uah / usd;
            }

            public double ConvertToEur(double uah)
            {
                return uah / eur;
            }

            public double ConvertToRub(double uah)
            {
                return uah / rub;
            }

            public double ConvertFromUsd(double usd)
            {
                return usd * this.usd;
            }

            public double ConvertFromEur(double eur)
            {
                return eur * this.eur;
            }

            public double ConvertFromRub(double rub)
            {
                return rub * this.rub;
            }
        }
    }

