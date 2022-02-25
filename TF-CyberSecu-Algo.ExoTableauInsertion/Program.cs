using System;

namespace TF_CyberSecu_Algo.ExoTableauInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[] { 1,2,3,5,6,7 };

            int value;
            do
            {
                Console.WriteLine("Veuillez indiquer un nombre : ");
            } while (!int.TryParse(Console.ReadLine(),out value));

            int position = tab.Length;
            bool NotFindIndex = true;
            for (int i = 0; i < tab.Length && NotFindIndex; i++)
            {
                if (value < tab[i]) { 
                    position = i; 
                    NotFindIndex = false; 
                }
            }

            for (int i = position; i < tab.Length; i++)
            {
                int temp = tab[i];
                tab[i] = value;
                value = temp;
            }

            foreach (int number in tab)
            {
                Console.WriteLine(number);
            }
        }
    }
}
