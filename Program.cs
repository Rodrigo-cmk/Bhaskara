using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {


            double a, b, c;
            double x1, x2, d;
            DateTime agora = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine($"Olá!!      ----          {agora}  ");
            Console.WriteLine("       Exercício Bhascara");
            Console.WriteLine();

            Console.WriteLine("- Cálculo das raízes de uma equação de segundo grau, utilizando o método de Bhaskara.");
            Console.WriteLine();

            Console.Write("Insira o valor 'a': ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (a == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Atenção!! O valor de 'a' não pode ser 0 na equação de 2º grau.");
                Console.ResetColor();
                Console.WriteLine();
                Environment.Exit(0);
            }

            Console.Write("Insira o valor 'b': ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira o valor 'c': ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            d = (Math.Pow(-b, 2)) - (4 * a * c);
            Console.WriteLine($"- Delta: {d}");
            Console.WriteLine();

            if (d < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Atenção!! Número negativo não possui raíz real.");
                Console.ResetColor();
                Console.WriteLine();
                Environment.Exit(0);
            }

            else if (d == 0)
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                Console.WriteLine($"- Resultado: {x1:N2}");
                Environment.Exit(0);
                Console.WriteLine();
            }

            x1 = (-b - Math.Sqrt(d)) / 2 * a;
            Console.WriteLine($"- Resultado 1: {x1:N2}");

            x2 = (-b + Math.Sqrt(d)) / 2 * a;
            Console.WriteLine($"- Resultado 2: {x2:N2}");













        }
    }
}
