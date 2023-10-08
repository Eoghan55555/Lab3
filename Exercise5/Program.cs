namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            int stocklevel, sales,remainingstock;
            bool validator = false;
            Console.Write("Enter Stock-On-Hand Level: ");
            stocklevel = int.Parse(Console.ReadLine());
            Console.Write("Enter Sales: ");
            sales = int.Parse(Console.ReadLine());
            validator = StockValidator(stocklevel, sales);
            if (validator==true) 
            {
                remainingstock = stocklevel - sales;
                Console.WriteLine($"Stock has been updated. Stock is now {remainingstock}");
            }
            else if (validator==false) 
            {
                Console.WriteLine("Error, cannot update stock.");
            }
        }
        static bool StockValidator(int stocklevel,int sales)
        {
            bool validator=false;
            if (stocklevel > sales)
            {
                validator = true;
            }
            else if (stocklevel < sales)
            {
                validator = false;
            }
            return validator;
        }
    }
}