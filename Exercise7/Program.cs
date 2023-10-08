namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalreviews=0;
            double[] averagefilm_review = {0,0,0};
            string[] filmtitles = { "Avengers Endgame", "Spider-Man: Far From Home", "Once Upon A Time in Hollywood" };
            double[][] filmReviews = new double[][]
            {
                new double[] {3,4},
                new double[] {1,2,1,3},
                new double[] {5,4,2}
            };
            for (int i = 0; i < filmReviews.Length; i++)
            {
                double total =0;

                for(int j = 0;j < filmReviews[i].Length; j++)
                {
                     total+= filmReviews[i][j];
                }
                averagefilm_review[i]=total / filmReviews[i].Length;
                Console.WriteLine($"Average rating for {filmtitles[i]} is {averagefilm_review[i]:N2}\n");
            }

        }
    }
}