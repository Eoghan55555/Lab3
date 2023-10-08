using System.Transactions;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age;
            Console.Write("Enter Age: ");
            age=int.Parse(Console.ReadLine());
            GetAccess(age);
            Console.WriteLine(GetAccess(age));
        }
        static bool GetAccess(int age)
        {
            bool validator = false;
            int[] agebrackets = {18, 19, 20, 21};
            for (int i = 0; i < 4; i++)
            {
                if (age == agebrackets[i])
                {
                    validator = true;
                }
            }
            return validator;
        }
    }
}