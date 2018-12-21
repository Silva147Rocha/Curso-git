using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse (Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] V = Console.ReadLine().Split(' ');
            string nome = V[0];
            char sexo = char.Parse( V[1]);
            int idade = int.Parse(V[2]);
            double altura = double.Parse(V[3], CultureInfo.InstalledUICulture);



            Console.WriteLine("você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(sexo);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InstalledUICulture));




            Console.ReadLine();

        }
    }
}
