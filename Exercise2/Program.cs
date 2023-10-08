using System.Text;
using System.Transactions;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"€{PriceMenu()}");
        }
        static double PriceMenu()
        {
            string input="";
            double cost;
            Console.Write("Enter Item: ");
            input = Console.ReadLine();
            switch (input)
            {
                case "Jeans":
                    cost=67.99; 
                    break;
                case "Jacket":
                    cost = 68.99;
                    break;
                case "Boots":
                    cost = 34.99;
                    break;
                case "Scarves":
                    cost = 10;
                    break;
                case "Belts":
                    cost = 10;
                    break;
                case "Socks":
                    cost = 10;
                    break;
                default:
                    cost = -999;
                    break;

            }
            return cost;
        }
        
    }
}