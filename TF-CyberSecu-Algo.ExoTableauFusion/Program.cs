using System;

namespace TF_CyberSecu_Algo.ExoTableauFusion
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int TAILLE1 = 4;
            //const int TAILLE2 = 5;
            //const int TAILLE3 = TAILLE1 + TAILLE2;

            int[] tab1 = new int[] { 3, 2, 5, 4 };
            int[] tab2 = new int[] { 1, 3, 7, 2, 6 };
            int[] tabFusion = new int[tab1.Length + tab2.Length];

            tabFusion[0] = tab1[0];

            for (int i = 1; i < tabFusion.Length; i++)
            {
                int inputValue;
                if (i < tab1.Length)
                {
                    inputValue = tab1[i];
                }
                else
                {
                    inputValue = tab2[i-tab1.Length];
                }
                for (int j = 0; j < i; j++)
                {
                    if(inputValue < tabFusion[j])
                    {
                        int temp = tabFusion[j];
                        tabFusion[j] = inputValue;
                        inputValue = temp;
                    }
                }
                tabFusion[i] = inputValue;
            }

            foreach (int number in tabFusion)
            {
                Console.WriteLine(number);
            }
        }
    }
}
