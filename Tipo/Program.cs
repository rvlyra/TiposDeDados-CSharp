using System;
using System.Globalization;

public class MainClass
{
    public static void Main(string[] args)
    {
        // Captura de dados com quebra de linha
        
        string[] fN = Console.ReadLine().Split(' ');
        string fname = fN[0];
        string lname = fN[1];

        Console.WriteLine($"O nome digitado foi: {fname} {lname}.");

        //string fname = Console.ReadLine();
        //string lname = Console.ReadLine();
        //Console.WriteLine($"O nome digitado foi: {fname} {lname} ");

    }
}
