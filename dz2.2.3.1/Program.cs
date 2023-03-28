using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2._2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice Check = new Invoice(5, "Man", "Store", "robot", 4);
            Check.CommodityPrice();
            Console.ReadKey();
        }
        class Invoice
        {
            private int quantity;
            private string article;
            public readonly int account; 
            public readonly string customer; 
            public readonly string provider;
            public Invoice(int account,string customer,string provider,string article, int quantity)
            {
                this.account = account;
                this.customer = customer;
                this.provider = provider;
                this.article = article;
                this.quantity = quantity;
            }
            public void CommodityPrice()
            {
                Console.WriteLine("Чек товара");
                Console.WriteLine("account:" + account);
                Console.WriteLine("name:" + customer);
                Console.WriteLine("provider:" + provider);
                switch (article)
                {
                    case "robot":
                        Console.WriteLine($"Price with tax:  {50 * quantity * 1.2} + $");
                        Console.WriteLine($"Price with no tax: {50 * quantity}  $");
                        break;
                    case "toy":
                        Console.WriteLine($"Price with tax: { 12 * quantity * 1.2} $");
                        Console.WriteLine($"Price with no tax: {12 * quantity} $");
                        break;
                    default:
                        Console.WriteLine("there is no such product");
                        break;
                }
            }
        }
    }
}
