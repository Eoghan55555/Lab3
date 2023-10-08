namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title1= "Avengers Endgame", title2= "Spider-Man: Far From Home", title3= "Once Upon A Time in Hollywood";
            double averagefilm_1, averagefilm_2, averagefilm_3;
            double[,] filmReviews = { { 3, 4, 5 }, { 1, 2, 1 }, { 5, 4, 2 } };

            //Film 1
            averagefilm_1 = (filmReviews[0, 0] + filmReviews[0, 1] + filmReviews[0, 2]) / 3;
            //Film 2
            averagefilm_2 = (filmReviews[1, 0] + filmReviews[1, 1] + filmReviews[1, 2]) / 3;
            //Film 3
            averagefilm_3 = (filmReviews[2, 0] + filmReviews[2, 1] + filmReviews[2, 2]) / 3;

            Console.WriteLine($"Average rating for {title1} is {averagefilm_1:N2}\n");
            Console.WriteLine($"Average rating for {title2} is {averagefilm_2:N2}\n");
            Console.WriteLine($"Average rating for {title3} is {averagefilm_3:N2}\n");
        }
    }
}