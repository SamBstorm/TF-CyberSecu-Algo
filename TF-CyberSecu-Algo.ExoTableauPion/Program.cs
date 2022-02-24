using System;

namespace TF_CyberSecu_Algo.ExoTableauPion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] tab = new bool[10];
            int positionPion = 0;
            tab[positionPion] = true;

            foreach (bool cell in tab)
            {
                if (cell) Console.Write("©");
                else Console.Write("_");
            }

            ConsoleKeyInfo touche = Console.ReadKey(true);
            while (touche.Key != ConsoleKey.Q)
            {
                if (touche.Key == ConsoleKey.G && positionPion > 0) {
                    tab[positionPion] = !(tab[positionPion]);
                    positionPion--; //positionPion = (positionPion == 0)? tab.Length -1 : positionPion-1;
                    tab[positionPion] = !(tab[positionPion]);
                }
                else if (touche.Key == ConsoleKey.D && positionPion < tab.Length - 1)
                {
                    tab[positionPion] = !(tab[positionPion]);
                    positionPion++;
                    tab[positionPion] = !(tab[positionPion]);
                }
                Console.Clear();
                foreach (bool cell in tab)
                {
                    if (cell) Console.Write("©");
                    else Console.Write("_");
                }
                touche = Console.ReadKey(true);
            }

        }
    }
}
