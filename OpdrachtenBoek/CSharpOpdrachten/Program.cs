namespace CSharpOpdrachten;

class Program
{
    static void Main(string[] args)
    {
        // comment de hoofdstuk die u wilt controleren
        //_______________________________________________________________
        //Hoofdstuk1
       //Schrijven schrijven = new Schrijven();
       //schrijven.Schrijft();
       
       //Hoofdstuk2
       //Lezen lezen = new Lezen();
       //lezen.Leest();
       
       //Hoofdstuk3
       //BasisVariabelen basis = new BasisVariabelen();
       //basis.Using();

       //Hoofdstuk4
       //BewerkingVariabelen bewerking = new BewerkingVariabelen();
       //bewerking.bewerking();
       
       //Hoofdstuk5
       CastingEnConversie casting = new CastingEnConversie();
       casting.castingenconversie();
       
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
        string userNamer = "Gebruikersnaam";
        Console.WriteLine(userNamer);
        Console.ReadLine();
        //12 
        Console.Write("voer uw leeftijd");
        string Waarde = Console.ReadLine();
        if (int.TryParse(Waarde, out int UserInput))
        {
            Console.WriteLine("Leeftijd shown");
        }
        else
        {
            Console.WriteLine("Leeftijd niet geldig");
        }

        //13
        int leeftijd = int.Parse(Console.ReadLine());
        Console.WriteLine("oke u bent {0} jaar oud.", leeftijd);
        //14
        Console.Write("Voer uw leeftijd in: ");

        if (int.TryParse(Console.ReadLine(), out int userAge))
        {
            Console.WriteLine("Leeftijd opgeslagen: " + userAge);
        }
        else
        {
            Console.WriteLine("Ongeldige invoer. Voer een geldig getal in voor leeftijd.");
        }
        //15
        Random rand = new Random();

        bool geraden = false;

        int getalRaden = rand.Next(0, 10);
        Console.WriteLine("Raad het getal van 0 tot 100 helemaal willekeurig");

        while (!geraden)
        {
            try
            {
                int getalInvoer = int.Parse(Console.ReadLine());

                if (getalInvoer == getalRaden)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Wow goed geraden! Het getal was inderdaad: " + getalRaden);
                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Helaas, niet het juiste getal. Probeer opnieuw!");
                    Console.ResetColor();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Voer een geldig getal in.");
            }
        }
    }
}

class BasisVariabelen
{
    public void Using()
    {
        //16 en 17
        int integer = 10;
        bool controle = true;
        double doubleSpeed = 0.893234;
        string spiderString = "John Doe";
        float doesFloating = 250f;
        //18
        integer = 45;
        doubleSpeed = 0.100;
        //19
        int integer2 = 50;
        //20
        Console.WriteLine("Variabeel integer2 = " + integer2);
        // 21 
        //je krijgt de variabeel te zien in de console als waarde, omdat je in de console.writeline de variabeel in de console ziet.
    }
}

class BewerkingVariabelen
{
    public void bewerking()
    {
        //22 
        char letter = '5';
        char letter2 = '7';
        Console.WriteLine($"char van waarde: {letter}");
        Console.WriteLine($"char van waarde: {letter2}");

        // 23
        int berekenDeChar = letter;

        // 24-25
        int result = berekenDeChar + (letter2 - '0');
        Console.WriteLine($"resultaat: {result}");
        //26 
        //ik kreeg 60 als resultaat in de console, ik verwachtte een ander getal maar het bleek wel goed als ik via de code doorleest.
        //27
        string Tekst = "GoodBye ";
        string Tekst2 = "World!";
        //28 
        string resulting = Tekst + Tekst2;
        //29-30
        Console.WriteLine($"Result string: {resulting}");
        //31
        int Eight = 8;
        int Nine = 9;
        int Ignore;
        //32 
        Ignore = Eight + Nine;
        //33
        Console.WriteLine("Result: " + Ignore);
        //34
        //ja dit klopt volgens de berekening omdat 8 + 9 is 17 en ignore is een int waarde zonder waarde
        //35
        string MijnString;
        string MijnString2 = "You have lost!";
        int MijnInt = MijnString2.Length;
        //36 
        MijnString = MijnInt.ToString();
        //37
        Console.WriteLine("Uitslag! " + MijnString);
        //38
        //ja, dit klopt volgens de berekening van de string met 14 karakters inclusief spaties
    }
}
class CastingEnConversie()
{
    public void castingenconversie()
    {
        //40
        int InvoerRechten = 8;
        char Fout = 'x';
        string FoutMelding = "Error 420";
        //41 - A-B-C 
        int help = Convert.ToInt32(Fout);
        Fout = Convert.ToChar(InvoerRechten);
        InvoerRechten = Convert.ToInt32(FoutMelding);
        //42
        char Protocol = '4';
        //43
        
    }
}