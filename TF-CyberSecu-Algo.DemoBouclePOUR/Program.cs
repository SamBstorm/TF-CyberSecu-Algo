using System;

namespace TF_CyberSecu_Algo.DemoBouclePOUR
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 10;
            int[] tableau = new int[TAILLE];
            tableau[0] = 2;
            int nbElement;
            for (nbElement = 1; nbElement < TAILLE; nbElement++)
            {
                tableau[nbElement] = tableau[nbElement - 1] * 2;
            }

            for (int i = 0; i < nbElement; i++)
            {
                Console.WriteLine(tableau[i]);
            }

        }
    }
}
