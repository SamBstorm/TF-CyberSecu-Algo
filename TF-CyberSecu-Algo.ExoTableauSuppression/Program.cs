using System;

namespace TF_CyberSecu_Algo.ExoTableauSuppression
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[] { 3,3,2,5,6,7 };
            int temp, count = 0;
            int value;
            do
            {
                Console.WriteLine("Veuillez indiquer le nombre à supprimer :");
            } while (!int.TryParse(Console.ReadLine(), out value));

            for (int i = 0; i < tableau.Length-count; i++)
            {
                if(value == tableau[i])
                {
                    tableau[i] = 0;
                    for (int j = i; j < tableau.Length-1; j++)
                    {
                        temp = tableau[j + 1];
                        tableau[j + 1] = tableau[j];
                        tableau[j] = temp;
                    }
                    i--;
                    count++;
                }
                
            }

            foreach (int number in tableau)
            {
                Console.WriteLine(number);
            }
        }
    }
}
