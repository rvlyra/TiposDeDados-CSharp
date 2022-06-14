using System;
using System.Globalization;

public class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Digite o primeiro nome, sexo, idade e altura");


        string[] arr = Console.ReadLine().Split(' ');
        string nome = arr[0];
        char sexo = char.Parse(arr[1]);
        int idade = int.Parse(arr[2]);
        double altura = double.Parse(arr[3], CultureInfo.InstalledUICulture);
        Console.WriteLine($"Nome: {nome}, Sexo: {sexo}, Idade: {idade}, Altura: {altura} ");


        /*
        Console.WriteLine("Texto normal");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Cores de Texto e fundo alteradas");
        Console.ResetColor();
        Console.WriteLine("Texto normal de novo");
        */

        /* 
        double n1 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
        double n3 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

        double sum = n1 + n2 + n3;
        double media = sum / 3;
        Console.WriteLine($"O aluno fez {sum} pontos. A resultado final é {media}.");

        string fname = Console.ReadLine();
        string lname = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Nome completo: {fname} {lname}. Idade: {age}.");
        */
    }
}
