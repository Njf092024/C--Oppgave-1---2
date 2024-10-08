using System.Runtime.InteropServices;

namespace C__Oppgave_1___2;

class Program
{
    static void Main(string[] args)
    {
        string myString = "surrender at fifteen!"; //Lag en variabel av datatypen string og tilden en vilkårlig tekst
        Console.WriteLine(myString);
        
        Console.WriteLine("Gang et hel tall med et annet, press enter for å fortsette");
        Console.ReadLine();

        

        int intnum01; //Lag en variabel av datatypen integer og tildel den et vilkårlig heltall
        int intnum02;

        Console.Write("Input a number: ");
        intnum01 = Convert.ToInt32( Console.ReadLine() );

        Console.Write("Input a second number:: ");
        intnum02 = Convert.ToInt32( Console.ReadLine() );

        Double result = intnum01 * intnum02;
        Console.WriteLine("The result is " + result);

      
        
       

        double double01; //Lag en variabel av datatypen double og tilden et vilkårlig tall, både desimal og heltall er gyldig med denne typen
        double double02;

        Console.WriteLine("Gang et hvilket som helst desimaltall med et annet, press enter for å fortsette");
        Console.ReadLine();

        Console.Write("Input a number: ");
        double01 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Input a second number: ");
        double02 = Convert.ToDouble(Console.ReadLine());

        double Doubleresult = double01 * double02;
        Console.WriteLine("The result is " + result);

        char myChar = 'N'; //Lag en variabel av datatypen char og tildel den en vilkårlig karakter(bokstav)
        Console.WriteLine(myChar);
        char myCharr = 'O';
        Console.WriteLine(myCharr);
        char myCharrr = 'O';
        Console.WriteLine(myCharrr);
        char myCharrrr = 'B';
        Console.WriteLine(myCharrrr);





        
    }
}
