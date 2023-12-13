namespace CSharpOpdrachten;

class Program
{
    static void Main(string[] args)
    {
        // comment de hoofdstuk die u wilt controleren
       /* Schrijven schrijven = new Schrijven();
        schrijven.Schrijft();*/
        Lezen lezen = new Lezen();
        lezen.Leest();
    }
}

class Schrijven
{
    public void Schrijft()
    {
        //1
        Console.WriteLine("Hello World!");
        Console.WriteLine("Hello World!");
        Console.WriteLine("Hello World!");
        //2
        Console.Write("Hello World!");
        Console.Write("Hello World!");
        Console.Write("Hello World!");
        //3
        //Console.Write legt the output naast 1 lijn terwijl writeline elk lijn uitvoert.
        
        //4
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Wrong!");
        Console.ResetColor();
        //5
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Return");
        //6
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Write("hello"); 
        Console.ResetColor(); // reset de kleur in de lijn 
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("world!");
        Console.ResetColor();
        //7
        void RestColor(string tekst, ConsoleColor voorKleur, ConsoleColor achterKleur)
        {
            
            ConsoleColor VoorKleur1 = Console.ForegroundColor;
            ConsoleColor AchterKleur1 = Console.BackgroundColor;

            try
            {
                
                Console.ForegroundColor = voorKleur;
                Console.BackgroundColor = achterKleur;

                
                Console.WriteLine(tekst);
            }
            finally
            {
                Console.ForegroundColor = VoorKleur1;
                Console.BackgroundColor = AchterKleur1;
            }
        }
    }
}

class Lezen
{
    //8.
    public void Leest()
    {
        //8
            string userName = Console.ReadLine();
            Console.WriteLine("Hello {0}!", userName);
        //9
        Console.WriteLine("\nHoe heet je?");
        String naam = Console.ReadLine();
        Console.WriteLine("Dus je heet: {0}!", naam + "\r\nWat een naam zeg!");
        //10
        Console.WriteLine("Wat is je Gebruikersnaam?");
        string UserName = Console.ReadLine();
        Console.WriteLine("Hello {0}!", userName);
        //11
        
        
        
        
    }
    
}