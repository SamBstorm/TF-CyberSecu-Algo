using System;

namespace TF_CyberSecu_Algo.DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //string test = Console.ReadLine();
            //Console.WriteLine($"Vous avez écrit : {test}");
            
            ConsoleKeyInfo touche;
            do
            {
                Console.Clear();
                Console.WriteLine("Veuillez appuyez sur 'A' :");
                touche = Console.ReadKey(true);
                Console.WriteLine($"Vous avez écrit : {touche.Key}");
            } while (touche.Key != ConsoleKey.A);
            Console.Clear();
            Console.WriteLine("Merci d'avoir appuyez sur 'A'...");
        }
    }
}
