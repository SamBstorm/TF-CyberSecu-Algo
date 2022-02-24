using System;

namespace TF_CyberSecu_Algo.ExoTableauDeSix
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 6;
            int[] tableau = new int[TAILLE];
            int nbElement = 0;
            while (nbElement < TAILLE)
            {
                Console.WriteLine("Veuillez indiquer un nombre entier :");
                tableau[nbElement] = int.Parse(Console.ReadLine());
                nbElement++;
            }
            int i = 0;
            while (i < nbElement)
            {
                Console.WriteLine(tableau[i]);
                i++;
            }        
        }
    }
}
