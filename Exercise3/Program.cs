namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            Zero(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
            
            
        }
        static void Zero(int[] zeroArr)
        {
            for (int i = 0; i < zeroArr.Length; i++)
            {
                zeroArr[i] = 0;
            }
        }
    }
}