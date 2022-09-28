using System.Runtime.CompilerServices;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Huvudmeny();
        }

        public static void MagicNumbers()
        {
            int födelseÅr;
            int skoStorlek;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("När är du född: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out födelseÅr)) ;
                Console.WriteLine("Vad är din skostorlek: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out skoStorlek)) break;
                Console.WriteLine("Ogiltligt val");
            }

            int a = födelseÅr - 6;
            int b = skoStorlek * 5;
            int c = b + 50;
            int d = c * 20;
            int e = d + 1016;
            int f = e - födelseÅr;

            Console.WriteLine($"Ditt födelseår minus 6 är {a}");
            Console.WriteLine($"Din skostorlek gånger 5 är = {b}");
            Console.WriteLine($"Plus 50 är lika med {c}");
            Console.WriteLine($"Gånger 20 är = {d}");
            Console.WriteLine($"Plus 1016 är = {e}");
            Console.WriteLine($"Minus ditt födelseår({födelseÅr}) är {f + 6}");
            Console.WriteLine($"Din skostorlek och ålder: {f}");
            Console.ReadKey();
            Console.Clear();
            Huvudmeny();

        }

        public static void CheckFor18()
        {
            Console.Clear();
            int ålder;
            while (true)
            {
                Console.WriteLine("Hur gammal är du? ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out ålder)) break;
                Console.WriteLine("Ogiltligt val.");
            }

            if (ålder == 18 || ålder > 18)
            {
                Console.WriteLine("Du är över 18 år!");
            }
            else
            {
                Console.WriteLine("Du är under 18.");
            }

            Console.ReadKey();
            Console.Clear();
            Huvudmeny();


        }

        public static void Greeting(string name)
        {
            Console.WriteLine($"Hej, {name}!");
            Console.ReadKey();
            Huvudmeny();
        }

        public static void Miniräknare()
        {
            float tal1 = 0;
            while (true)
            {
                Console.Write("Ange tal1: ");
                string nummerInput = Console.ReadLine();
                if (float.TryParse(nummerInput, out tal1)) break;
                Console.WriteLine("Ogiltligt val.");
            }

            float tal2 = 0;
            while (true)
            {
                Console.Write("Ange tal1: ");
                string nummerInput = Console.ReadLine();
                if (float.TryParse(nummerInput, out tal2)) break;
                Console.WriteLine("Ogiltligt val.");
            }

            Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
            Console.ReadKey();
            Console.Clear();
            Huvudmeny();
        }

        public static void Huvudmeny()
        {
            Console.WriteLine("1. Check for 18");
            Console.WriteLine("2. Miniräknare");
            Console.WriteLine("3. Greeting");
            Console.WriteLine("4. Magic Numbers");
            Console.WriteLine("5. Temperaturomvandling");
            Console.WriteLine("6. Magisk ålder");
            Console.WriteLine("A. Avsluta");
            
            string användaresVal = "";
            while (användaresVal != "a")
            {
                användaresVal = Console.ReadLine().ToLower();
                switch (användaresVal)
                {
                    case "1":
                        CheckFor18();
                        break;
                    case "2":
                        Miniräknare();
                        break;
                    case "3":
                        string name;
                        Console.Write("Skriv in ditt namn: ");
                        name = Console.ReadLine();
                        Greeting(name);
                        break;
                    case "4":
                        MagicNumbers();
                        break;
                    case "5":
                        TemperaturOmvandling();
                        break;
                    case "6":
                        MagiskÅlder();
                        break;
                    case "a":
                        Console.WriteLine("Bye bye...");
                        break;
                    default:
                        Console.WriteLine("Fel input");
                        break;
                }
            }
        }

        public static void TemperaturOmvandling()
        {
            Console.Clear();
            float temp;
            while (true)
            {
                Console.WriteLine("Ange temp i celsius: ");
                string input = Console.ReadLine();
                if (float.TryParse(input, out temp)) break;
                Console.WriteLine("Ogiltligt val...");
            }

            Console.WriteLine($"Faharenheit: {temp * 1.8 + 32}");
            Console.ReadKey();
            Console.Clear();
            Huvudmeny();
        }

        public static void MagiskÅlder()
        {
            Console.Clear();
            int ålder;
            int födelseÅr;
            while (true)
            {
                Console.WriteLine("Ange din ålder (som du fyller detta år): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out ålder)) ;
                Console.WriteLine("Ange ditt födelseår: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out födelseÅr)) break;
                Console.WriteLine("Ogiltligt val...");
            }

            Console.WriteLine($"Din ålder ({ålder}) plus ditt ({födelseÅr}) = {ålder + födelseÅr}");
            Console.WriteLine("coolt!!!");
            Console.ReadKey();
            Console.Clear();
            Huvudmeny();

        }
    }
}