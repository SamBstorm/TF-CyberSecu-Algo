using System;

namespace TF_CyberSecu_Algo.DemoTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int TAILLE = 7;
            //double[] tabCotes = new double[TAILLE];

            //Console.WriteLine("Veuillez indiquer la première côte :");
            //tabCotes[0] = double.Parse(Console.ReadLine());
            //Console.WriteLine("Veuillez indiquer la seconde côte :");
            //tabCotes[1] = double.Parse(Console.ReadLine());
            //Console.WriteLine("Veuillez indiquer la troisième côte :");
            //tabCotes[2] = double.Parse(Console.ReadLine());

            //double moyenne = tabCotes[0];
            //moyenne = moyenne + tabCotes[1];
            //moyenne += tabCotes[2];         //moyenne = moyenne + tabCotes[2];

            //Console.WriteLine("La moyenne de la classe est de "+ (moyenne/TAILLE));

            const int TAILLE = 12;
            int[] tab = new int[TAILLE];
            int nbElement = 0;

            while (nbElement < TAILLE)
            {
                tab[nbElement] = int.Parse(Console.ReadLine());
                nbElement++;
            }

            Console.Read();
        }
    }
}
