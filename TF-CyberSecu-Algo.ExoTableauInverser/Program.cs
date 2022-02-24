using System;

namespace TF_CyberSecu_Algo.ExoTableauInverser
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 7;
            string[] tableau = new string[TAILLE];
            int nbElements = 0;

            do
            {
                Console.WriteLine("Veuillez introduire un nombre :");
                tableau[nbElements] = Console.ReadLine();
                nbElements++;
            } while (nbElements < TAILLE);

            foreach (string mot in tableau)
            {
                Console.WriteLine(mot);
            }

            for (int i = 0; i < (TAILLE / 2); i++)
            {
                string temp = tableau[TAILLE - 1 - i];
                tableau[TAILLE - 1 - i] = tableau[i];
                tableau[i] = temp;
            }
            //Array.Reverse(tableau);

            foreach (string mot in tableau)
            {
                Console.WriteLine(mot);
            }
        }
    }
}
