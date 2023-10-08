using System.ComponentModel.Design;
using System.Diagnostics;

namespace Exercise9
{
    internal class Program
    {
        static string filepath = @"../../../sales.txt";//Sales.txt is here to save space from declaring in each method
        static void Main(string[] args)

        {
            string[] lines = File.ReadAllLines(filepath);//Allows the arrays to be set up with the length of the file
            //variables
            int aver_sales, total_sales;
            int[] salesArr= new int[lines.Length];
            string[] storeID= new string[lines.Length];
            string[] perfromance_comments = new string[lines.Length];
            //Methods + variables to mirror the methods' value to allow for easier pssing of data
            storeID = GetStoreID();
            salesArr = GetIndividualSales();
            total_sales = TotalSalesCalc(salesArr);
            aver_sales = AverageSalesCalc(total_sales);
            perfromance_comments=GetPerformanceComment(salesArr);
            MenuDsiplay(storeID,salesArr,total_sales,aver_sales,perfromance_comments);
            
            
        }
        static private string[] GetStoreID()
        {
            string[] lines = File.ReadAllLines(filepath);
            string[] storeID = new string[lines.Length];
            try
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    storeID[i] = lines[i].Split(',')[0];//Splits the text into,e.g. 'S1' '500' and allows the array to contain only the first part.
                }
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message + "Store ID Message");
            }
            return storeID;
        }
        static private int[] GetIndividualSales()
        {
            string[] lines = File.ReadAllLines(filepath);
            int[] salesArr = new int[lines.Length];
            try
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    salesArr[i] = int.Parse(lines[i].Split(",")[1]);//Same story as the previous split but this takes the second part and turns the string into an int
                }
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message+"Individual Sales Message");
            }
            return salesArr;
        }
        static private int TotalSalesCalc(int[] ind_sales)
        {
            int totalSales=0;
            string[] lines = File.ReadAllLines(filepath);
            for (int i = 0; i < lines.Length; i++)
            {
                totalSales += ind_sales[i];//Gets the total by adding each individual sale from the array in the method above and itself
            }
            return totalSales;
        }
        static private int AverageSalesCalc(int total_sales)
        {
            int averageSales;
            string[] lines = File.ReadAllLines(filepath);
            averageSales = total_sales/lines.Length;//Gets the average from the total by dividing from the length of the file.
            return averageSales;
        }
        static private string[] GetPerformanceComment(int[] salesArr)
        {
            string[] lines = File.ReadAllLines(filepath);
            string[] performanceCommentArr=new string[lines.Length];//Gets a performance comment that can be linked up with the individual sales by using the two arrays later.
            for (int i=0; i < lines.Length; i++)
            {
                if (salesArr[i] < 1000)
                {
                    performanceCommentArr[i] = "Needs Attention";
                }
                else if (salesArr[i] >= 1000 && salesArr[i] < 1999)
                {
                    performanceCommentArr[i] = "Moderate";
                }
                else 
                {
                    performanceCommentArr[i] = "Very Good";
                }
            
            }
            return performanceCommentArr;
        }
        static private void MenuDsiplay(string[] storeID, int[] salesArr, int total_sales, int aver_sales, string[] performance_comments)
        {
            string formattedColumnHeadings = string.Format("{0,-15}{1,-15}{2}", "StoreID", "Sales", "Performance"); //Format for the top columns
            string[] lines = File.ReadAllLines(filepath);
            Console.WriteLine("Sales Report\n");
            Console.WriteLine(formattedColumnHeadings+"\n");
            for(int i = 0; i < lines.Length; i++)//using a for loop allows each array to have a different value but still linked to the other columns when being looped
            {
                string formattedArrayInfo = string.Format("{0,-15}{1,-15}{2}", storeID[i], salesArr[i], performance_comments[i]);//Format for the data in the columns. 
                Console.WriteLine(formattedArrayInfo+"\n");
            }
            Console.WriteLine($"Total Sales: {total_sales}\n");
            Console.WriteLine($"Average Sales: {aver_sales}\n");
        }
    }
}
