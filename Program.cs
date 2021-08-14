using System;

namespace Cidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Cidades do Litoral Sul se SP");
            Console.ResetColor();

            Console.WriteLine();  
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Canaéia" +
            "\nGuarujá" +
            "\nIguape" +
            "\nIlha Comprida" +
            "\nItanhaém" +
            "\nJuréia");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Mongaguá");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Peruíbe" +
            "\nPraia Grande" +
            "\nSão Vicente" +
            "\nSantos" +
            "\nCubatão");

            Console.ResetColor();
        }
    }
}
