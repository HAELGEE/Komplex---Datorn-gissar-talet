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

        string higher;
        string lower;        

        Console.Write("Skriv ett tal som datorn skall gissa på: ");
        str = Convert.ToInt32(Console.ReadLine());

        //bool program = true;
        while (true)
        {
            
            int nr = random.Next(ett, hundraett);
            Console.WriteLine($"Jag gissar på {nr} är det Rätt?\nEller är ditt tal [H]ögre eller [L]ägre?");
            string svar = Console.ReadLine();

            if (nr < str)
            {                
                ett = nr + 1;                
            }
            else if (nr > str) 
            {
                hundraett = nr - 1;                
            }
            if (nr == str) 
            {
                break;
                //program = false;
            }
            antal++;
        }      
        
        Console.WriteLine($"Hurra jag (tHe SmArTeSt CoMpUtEr 0f th3 w0rlD) klarade det på {antal} gånger =D=D=D=D=D=D");
    }     
}
