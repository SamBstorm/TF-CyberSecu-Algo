using System;

namespace TF_CyberSecu_Algo.ExoTableauExposantDeux
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 10;
            int[] tableau = new int[TAILLE];
            tableau[0] = 2;
            int nbElement = 1;
            while (nbElement < TAILLE)
            {
                tableau[nbElement] = tableau[nbElement - 1] * 2;
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
