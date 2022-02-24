using System;

namespace TF_CyberSecu_Algo.ExoTableauScore
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Version algo
            const int TAILLE = 10;
            int[] scores = new int[TAILLE];
            int nbElements;

            int nbJoueurs;
            do
            {
                Console.WriteLine($"Veuillez indiquer le nombre de joueurs (de 2 à {TAILLE}):");
                nbJoueurs = int.Parse(Console.ReadLine());
            } while (nbJoueurs < 2 || nbJoueurs > TAILLE);

            for (nbElements = 0; nbElements < nbJoueurs; nbElements++)
            {
                Console.WriteLine($"Veuillez introduire le score du joueur {nbElements + 1} :");
                scores[nbElements] = int.Parse(Console.ReadLine());
            }

            float moyenne = 0;
            for (int i = 0; i < nbElements; i++) moyenne += scores[i];
            Console.WriteLine($"La moyenne est de : {moyenne / nbJoueurs}");
            #endregion

            #region Version optimisée
            //const int MAX = 10;
            //const int MIN = 2;
            //int nbJoueurs;
            //do
            //{
            //    do
            //    {
            //        Console.WriteLine($"Veuillez indiquer le nombre de joueurs (de {MIN} à {MAX}):");
            //    } while (!int.TryParse(Console.ReadLine(), out nbJoueurs));
            //} while (nbJoueurs < MIN || nbJoueurs > MAX);

            //int[] scores = new int[nbJoueurs];
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Veuillez introduire le score du joueur {i + 1} :");
            //    } while (!int.TryParse(Console.ReadLine(), out scores[i]));
            //}
            //float moyenne = 0;
            //foreach (int score in scores)
            //{
            //    moyenne += score;
            //}
            //Console.WriteLine($"La moyenne est de : {moyenne / scores.Length}");
            #endregion

        }
    }
}
