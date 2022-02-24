using System;

namespace TF_CyberSecu_Aglo.ExoSapin
{
    class Program
    {
        static void Main(string[] args)
        {
            const char CARACTERE = 'A';
            const char BOULE = 'O';
            string text = "A";
            Console.WriteLine("Veuillez indiquer le nombre de lignes :");
            int hauteurSapin = int.Parse(Console.ReadLine());
            int nbLigne = 0;
            while (nbLigne < hauteurSapin)
            {
                int nbEspace = 0;
                while (nbEspace < hauteurSapin-nbLigne)
                {
                    Console.Write(" ");
                    nbEspace++;
                }
                Console.WriteLine(text);
                if (nbLigne % 2 == 0)
                    text = BOULE.ToString() +text + BOULE.ToString();
                else
                    text = CARACTERE.ToString() + text + CARACTERE.ToString();
                nbLigne++;
            }

            int largeurTronc = (hauteurSapin/2);
            if(largeurTronc%2 == 0) 
                largeurTronc = largeurTronc + 1;

            int espaceTronc = hauteurSapin - (largeurTronc / 2);
            while (espaceTronc > 0) {
                Console.Write(" ");
                espaceTronc--;
            }
            while(largeurTronc > 0)
            {
                Console.Write(CARACTERE);
                largeurTronc--;
            }
        }
    }
}
