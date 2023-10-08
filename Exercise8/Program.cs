namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playernumber=0;
            List<string> players = new();
            Console.WriteLine("-1 to break");
            while (true)
            {
                Console.Write($"--- Enter Player Name: ");
                string input= Console.ReadLine();
                if ( input == "-1")                
                    break;

                players.Add(input);
                playernumber++;

            }
            players.Sort();
            Console.WriteLine("Team");
            playernumber = 0;
            foreach (string player in players)
            {
                
                Console.WriteLine($"#{playernumber+1} {player}");
                playernumber++;
            }

        }
    }
}