using System;

namespace TF_CyberSecu_Algo.ExoTableauTri
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 7;
            int[] tableau = new int[] { 3,2,1,4,5,6,7 };

            bool havePermutation = true;
            for (int i = 0; i < TAILLE - 1 && havePermutation; i++)
            {
                havePermutation = false; //Contrôle si une permutation à été effectué, si pas de parmutation = tableau trié
                //PASS
                for (int j = i + 1; j < TAILLE; j++)
                {
                    if (tableau[i] >= tableau[j])
                    {
                        int temp = tableau[j];
                        tableau[j] = tableau[i];
                        tableau[i] = temp;
                        havePermutation = true;
                    }
                }
            }
            //Array.Sort(tableau);

            foreach (int value in tableau)
            {
                Console.WriteLine(value);
            }
        }
    }
}
