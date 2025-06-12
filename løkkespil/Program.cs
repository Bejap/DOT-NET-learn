using System;

namespace WhoLikesCounting
{
    class CountTo10
    {
        static void Main(string[] args)
        {
            /* int j = 0; */
            /* Console.WriteLine("Action performed wtih a for loop");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Action performed with while loop");
            while (j < 11)
            {
                Console.WriteLine(j);
                j++; */

            /* for (int o = 1; o < 26; o += 2)
            {
                Console.WriteLine(o);
            } */

            /* Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                int tal = rnd.Next(1, 7);
                Console.WriteLine(tal);
            }

            while (j < 6)
            {
                int tal = rnd.Next(1, 7);
                Console.WriteLine(tal);
                j++;
            } */

            /* for (int i = 0; i < 26; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            while (j < 26)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            } */

            /* for (int i = 0; i < 25; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            } */

            /* Console.Write("Enter a number: ");
            string? str = Console.ReadLine();

            if (int.TryParse(str, out int n))
            {
                Console.WriteLine($"The first {n} natural numbers:");
                PrintNaturalNumbers(n);

                int sum = SumOfNaturalNumbers(n);
                Console.WriteLine($"The sum of the first {n} natural numbers is {sum}");

                Console.WriteLine($"The first {n} of the fibonacci sequence");
                PrintFibonacci(n);

                int fact = NFactorial(n);
                Console.WriteLine($"The factorial of {n} is {fact}");

                if (IsPrime(n))
                    Console.WriteLine($"{n} er et primtal.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            } */

            Console.Write("How many players do you want to be? ");
            string players = Console.ReadLine();

            if (int.TryParse(players, out int numPlayers))
                ActivateGame(numPlayers);
            else
                Console.WriteLine("Invalid, you need to enter an integer.");

        }
        // 5.1
        static void PrintNaturalNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        // 5.2
        static int SumOfNaturalNumbers(int n)
        {
            int sum = n * (n + 1) / 2;
            return sum;
        }
        // 5.3
        static void PrintFibonacci(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Indtast venligst et positivt tal.");
                return;
            }

            long a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);
                long temp = a;
                a = b;
                b = temp + b;
            }
        }
        // 5.4
        static int NFactorial(int n)
        {
            int factor = 1;
            for (int i = 1; i < n + 1; i++)
            {
                factor *= i;
            }
            return factor;
        }
        // 5.5
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static void ActivateGame(int numPlayers)
        {
            string[] playerNames;
            playerNames = new string[numPlayers];
            int[] sumArray;
            sumArray = new int[numPlayers];
            sumArray[0] = 0;
            sumArray[1] = 0;
            int i = 1;
            while (i < numPlayers + 1)
            {
                Console.Write($"please enter player {i}'s name: ");
                string name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    playerNames[i - 1] = name;
                    i++;
                }
                else
                {
                    Console.WriteLine("Invalid name. Please try again.");
                }
            }



            while (sumArray.Max() <= 100)
            {
                for (int player = 0; player < numPlayers; player++)   
                    {
                    int valueFromDie;
                    int sum = 0;
                    Console.WriteLine($"{playerNames[player]}'s turn");
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
                        sumArray[player] += sum;
                }
                Console.WriteLine("Current scores:");
                for (int j = 0; j < numPlayers; j++)
                    Console.WriteLine($"{playerNames[j]}: {sumArray[j]}");
            }
            Console.WriteLine("Final scores:");
            for (int j = 0; j < numPlayers; j++)
                Console.WriteLine($"{playerNames[j]}: {sumArray[j]}");
        }

        static int RollDie()
        {
            Random rnd = new Random();
            int dieValue = rnd.Next(1, 7);
            Console.WriteLine($"You rolled a/an {dieValue}");
            if (dieValue == 1)
            {
                return 0;
            }
            return dieValue;
        }
    }
}
