using ClassWork_C_Sharp;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("How many players do you want to be? ");
        string number = Console.ReadLine();
        if (int.TryParse(number, out int numPlayers))
        {
            List<Player> players = new List<Player>();

            int i = 1;
            while (i < numPlayers + 1)
            {
                Console.Write($"please enter player {i}'s name: ");
                string name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    players.Add(new Player(name, 0));
                    i++;
                }
                else
                {
                    Console.WriteLine("Invalid name. Please try again.");
                }
            }
            while (players.Max(p => p.Score) <= 100)
            {
                foreach (Player player in players)
                {
                    player.Play();
                    Console.WriteLine(player.ToString());
                    if (player.Score == 0)
                    {
                        player.Score = 20;
                        /* Console.Write("Do you want to change the name (give nonzero character)? ");
                        string changeName = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(changeName))
                        {
                            Console.Write("Write new name: ");
                            string name = Console.ReadLine();
                            player.Name = name;
                        } */
                    }
                }  
            }
        }
        else
            Console.WriteLine("Invalid, you need to enter an integer.");
    }
}
