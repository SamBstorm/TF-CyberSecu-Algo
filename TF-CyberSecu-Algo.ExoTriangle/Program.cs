using System;

namespace TF_CyberSecu_Algo.ExoTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            const char CARACTERE = 'A';
            string text = "";
            Console.WriteLine("Veuillez indiquer le nombre de lignes :");
            int nbLigne = int.Parse(Console.ReadLine());
            while (nbLigne > 0)
            {
                text = text + CARACTERE;
                Console.WriteLine(text);
                nbLigne--;
            }
        }
    }
}
