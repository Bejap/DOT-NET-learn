namespace ClassWork_C_Sharp
{
    class Player
    {
        public string name;
        public int score;

        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public override string ToString()
        {
            return $"Name: {name}, Score: {score}";
        }

        public void Play()
        {
            int valueFromDie;
            int sum = 0;
            Console.WriteLine($"{name}'s turn");
            Console.WriteLine("Current score:");
            Console.WriteLine($"{name}: {score}");
            Console.Write("Would you like to roll the die(y/n)? ");
            string roll = Console.ReadLine();
            while (roll != "n")
            {
                valueFromDie = RollDie();
                if (valueFromDie == 0)
                    break;
                sum += valueFromDie;
                Console.Write("Would you like to roll again(y/n)? ");
                roll = Console.ReadLine();
            }
            if (roll == "n")
                score += sum;
        }

        static int RollDie()
        {
            Random rnd = new Random();
            int dieValue = rnd.Next(1, 7);
            Console.WriteLine($"You rolled a/an {dieValue}");
            Console.WriteLine();
            if (dieValue == 1)
            {
                return 0;
            }
            return dieValue;
        }
    }
}