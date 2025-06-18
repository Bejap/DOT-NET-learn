namespace MyFirstConsoleProject
{
    public class Miner
    {
        public string Name { get; set; }
        public int Sleepiness { get; set; }
        public int Thirst { get; set; }
        public int Hunger { get; set; }
        public int Whisky { get; set; }
        public int Gold { get; set; }
        public int RoundNumber { get; set; }

        public Dictionary<string, object> MinerData { get; set; }

        public Miner(string name)
        {
            Name = name;
            Sleepiness = 0;
            Thirst = 0;
            Hunger = 0;
            Whisky = 0;
            Gold = 0;
            RoundNumber = 0;

            MinerData = new Dictionary<string, object>
            {
                {"miner", Name},
                { "round", RoundNumber },
                { "sleepiness", Sleepiness },
                { "thirst", Thirst },
                { "hunger", Hunger },
                { "whisky", Whisky },
                { "gold", Gold }
            };
        }

        private void Mine()
        {
            Gold += 5;
            Thirst += 5;
            Hunger += 5;
            Sleepiness += 5;
            RoundNumber++;
        }
        private void Drink()
        {
            Whisky -= 1;
            Thirst -= 15;
            Hunger -= 1;
            Sleepiness += 5;
            RoundNumber++;
        }

        private void Sleep()
        {
            Thirst += 1;
            Hunger += 1;
            Sleepiness -= 10;
            RoundNumber++;    
        }
        private void BuyWhisky()
        {
            Whisky += 1;
            Gold -= 1;
            Thirst += 1;
            Hunger += 1;
            Sleepiness += 5;
            RoundNumber++;
        }
        private void Eat()
        {
            Gold -= 2;
            Thirst -= 5;
            Hunger -= 20;
            Sleepiness += 5;
            RoundNumber++;
        }

        public bool Dead()
        {
            return Sleepiness > 100 || Thirst > 100 || Hunger > 100;
        }

        public void PerformRound()
        {
            if (Sleepiness >= 95)
            {
                Sleep();
            }
            else if (Hunger >= 94)
            {
                Eat();
            }
            else if (Thirst >= 93)
            {
                BuyWhisky();
                if (!Dead())
                    Drink();
            }
            else
            {
                Mine();
            }
        }
    }
}