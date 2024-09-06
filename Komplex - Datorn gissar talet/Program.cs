using System.ComponentModel.Design;

namespace Komplex___Datorn_gissar_talet;

internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int str;
        int antal = 0;
        int ett = 1;
        int hundraett = 100;

        int nr = random.Next(ett, hundraett);

        while (true)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("=============== Program ===============");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Skriv ett tal som datorn skall gissa på (mellan 1 och 100): ");

                str = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            }
            catch
            {
                Console.WriteLine("Skriv ett nummer istället!");
                Console.Clear();
            }
        }

        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Talet som datorn skall gissa är {str}\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"Jag gissar på ");

            Console.ForegroundColor = nr == str ? ConsoleColor.Green : ConsoleColor.Red;
            Console.Write(nr);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(". Är det [R]ätt\nEller är det [H]ögre, eller [L]ägre?");

            string svar = Console.ReadLine().ToLower();

            while (nr != nr)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            if (svar == "r" && nr == str)
            {
                antal++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Hurra jag (tHe SmArTeSt CoMpUtEr 0f th3 w0rlD) klarade det på {antal} gånger =D=D=D=D=D=D");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            }
            else if (svar == "h")
            {
                if (nr < str)
                {
                    ett = nr + 1;
                    nr = random.Next(ett, hundraett);
                    antal++;
                }
                else
                {
                    Console.WriteLine("Gör om, gör rätt");                    
                    Console.ReadKey();
                }
            }
            else if (svar == "l")
            {
                if (nr > str)
                {
                    hundraett = nr - 1;
                    nr = random.Next(ett, hundraett);
                    antal++;
                }
                else
                {
                    Console.WriteLine("Gör om, gör rätt");                    
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Gör om, gör rätt");                
                Console.ReadKey();
            }
        }
    }
}
    
