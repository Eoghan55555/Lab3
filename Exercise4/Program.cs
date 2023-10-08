namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_1,num_2,lowest_Num;
            Console.Write("Enter Number 1: ");
            num_1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            num_2 = int.Parse(Console.ReadLine());
            lowest_Num = LowestNum(num_1,num_2);
            Sum(num_1 ,num_2,lowest_Num);
        }
        static int LowestNum(int num1,int num2)
        {
            int lowestnum;
            if (num1 < num2) 
            { 
                lowestnum = num1;
            }
            else
            {
                lowestnum = num2;
            }
            return lowestnum;
        }
        static int Sum(int num1, int num2,int lowestNum)
        {
            int totalAmount=0;
            if (num1==lowestNum)
            {
                for (int i = num1;i<=num2 ;i++)
                {
                    totalAmount += i;
                }
            }
            else if(num2==lowestNum)
            {
                for (int i = num2; i <= num1; i++)
                {
                    totalAmount += i;
                }
            }
            else
            {
                Console.WriteLine("Error Occured");
            }
            return totalAmount;
        }
    }
}