using System;

namespace TF_CyberSecu_Algo.ExoTableauPlusPetit
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 10;
            int[] tableau = new int[TAILLE];

            for (int i = 0; i < TAILLE; i++)
            {
                do
                {
                    Console.WriteLine("Veuillez indiquer un nombre : ");
                } while (!int.TryParse(Console.ReadLine(), out tableau[i]));

                //VERSION LONGUE des lignes 14 à 17
                //string input;
                //bool isNotOk;
                //do
                //{
                //    Console.WriteLine("Veuillez indiquer un nombre : ");
                //    input = Console.ReadLine();
                //    isNotOk = !int.TryParse(input, out tableau[i]);
                //} while (isNotOk);
            }

            int min= tableau[0];

            for (int i = 1; i < TAILLE; i++)
            {
                if (min > tableau[i])
                {
                    min = tableau[i];
                }
            }

            Console.WriteLine($"La plus petite valeur est  : {min}.");
        }
    }
}
