using System.Net.Security;

namespace MyFirstConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Indtast navneord: ");
            string navn = Console.ReadLine();
            Console.Write("Indtast udsagnsord: ");
            string udsagn = Console.ReadLine();
            Console.Write("Indtast tillægsord i flertal: ");
            string till = Console.ReadLine();
            Console.Write("Indtast navneord: ");
            string navn2 = Console.ReadLine();
            Console.WriteLine($"Masser af {navn}");
            Console.WriteLine($"Og det der {udsagn} til");
            Console.WriteLine($"Masser af {till} spotlights");
            Console.WriteLine($"Privatliv og {navn2}"); */

            /* Console.Write("Intast et tal: ");
            int tal = int.Parse(Console.ReadLine());
            Add12(tal); */

            // eller

            /* Console.Write("Intast et tal: ");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine($"Variablen er nu øget med 12, og har nu fået værdien {tal + 12}"); */

            /* Console.WriteLine(">>Velkommen til taxaberegner<<");
            Console.Write("Indtast antal kilometer: ");
            int kilometer = int.Parse(Console.ReadLine());
            Console.Write($"Pris for taxatur: {(kilometer * 9) + 29}"); */

            /* Console.Write("Indtast tal: ");
            string tal1 = Console.ReadLine();
            int.TryParse(tal1, out int tal1Int);
            Console.Write("Indtast tal: ");
            string tal2 = Console.ReadLine();
            int.TryParse(tal2, out int tal2Int);

            int sum = tal1Int + tal2Int;
            Console.WriteLine($"Summen af {tal1Int} og {tal2Int} er {sum}"); */

            /* Console.WriteLine("indtast navn, alder, hobby, og år du har dyrket den hobby: ");
            string userName = Console.ReadLine();
            string userAge = Console.ReadLine();
            string userHobby = Console.ReadLine();
            string userHobbyAge = Console.ReadLine();
            int.TryParse(userAge, out int age);
            int.TryParse(userHobbyAge, out int hobbyage);
            NavnOgHobby(userName, age, userHobby, hobbyage); */

            
        }
        static void Hello()
        {
            Console.WriteLine("Hello OSTDD");
        }

        static void Trylleri()
        {
            Console.WriteLine("hokus pokus");
        }
        static void Add12(int tal)
        {
            int talMed12 = tal + 12;
            Console.WriteLine($"Variablen er nu øget med 12, og har nu fået værdien {talMed12}");
        }

        static void NavnOgHobby(string name, int age, string hobby, int hobbyAge)
        {
            Console.WriteLine($"Hej {name}, din hobby er {hobby}. Du begyndte at dyrke");
            Console.WriteLine($"{hobby} i {2025 - hobbyAge} i en alder af {age - hobbyAge} år");
        }
    }
}
