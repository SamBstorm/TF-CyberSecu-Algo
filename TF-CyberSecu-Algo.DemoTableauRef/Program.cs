using System;

namespace TF_CyberSecu_Algo.DemoTableauRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t1 = new int[] { 1, 2, 3, 4 };    //Référence, donc une copie de l'adresse mémoire
            int[] t2 = t1;                          //Donc il s'agit pas d'une copie des valeurs, mais bien un nouveau lien vers la même valeur.

            t1[0] = 5;
            showArray(t1);
            showArray(t2);
        }

        public static void showArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
