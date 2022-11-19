public class LeetCode
{
    public static void Main(string[] arg)
    {
        while (true)
        {
            Console.Write("Zadejte číslo: ");

            string input = Console.ReadLine();
            if (input == "n" || input == "N")
            {
                Console.WriteLine("Ukončuji program...");
                System.Threading.Thread.Sleep(900);
                break;
            }
            int x = int.Parse(input);

            /*int x; int.Parse(input);
            while (!int.TryParse(input, out x))
            {
                Console.WriteLine();
            }*/

            if (x % 2 == 0)
            {
                Console.WriteLine("Je sudé");
            }

            else
            {
                Console.WriteLine("Je liché");
            }
            

            //Console.ReadKey();

        }


    }
}

