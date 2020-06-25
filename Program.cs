using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibon = new Fibonacci();
           
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine( "                 Sequência de Fibonacci                ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            fibon.GerarSequenciaFibonacci(0,1,15);
            Console.ResetColor();
            System.Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("                    Gerando fatorial do número 5            ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine(fibon.GerarFatorial(5));
            Console.ResetColor();
        }
    }
}
