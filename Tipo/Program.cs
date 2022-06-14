using System;
using System.Globalization;

public class MainClass
{
    public static void Main(string[] args)
    {
       double n1 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
       double n2 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
       double n3 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

       double sum = n1 + n2 + n3;
       double media = sum / 3;
       Console.WriteLine($"O aluno fez {sum} pontos. A resultado final é {media}.");

       /* 
       string fname = Console.ReadLine();
       string lname = Console.ReadLine();
       int age = int.Parse(Console.ReadLine());
       Console.WriteLine($"Nome completo: {fname} {lname}. Idade: {age}.");
       */
    }
}
