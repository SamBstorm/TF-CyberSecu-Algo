using System;

namespace TF_CyberSecu_Algo.DemoSousProgVarGlobal
{
    class Program
    {
        static string message = "Hello World!";     //Variable globale : A éviter (sauf une fois l'Orienté objet vu ;) )
        static void Main(string[] args)
        {
            string nomDeUtilisateur = "Sam";
            nomDeUtilisateur = MettreEnMajuscule(nomDeUtilisateur);
            DireBonjour(nomDeUtilisateur, false);
            int chiffre = 5;
            chiffre = MultiplierPar2(chiffre);
            Console.WriteLine(chiffre);
        }

        public static void DireBonjour(string name, bool estUneFemme) {
            Console.WriteLine($"{BonjourMonsieurMadame(estUneFemme)} {name}!");
        }


        public static string MettreEnMajuscule(string text)
        {
            string result = text.ToUpper(); //ToUpper() met le texte qui l'appelle en majuscule
            return result;
        }

        public static string BonjourMonsieurMadame(bool isFemale)
        {
            /*
            string result;
            if (isFemale) result = "Bonjour Madame";
            else result = "Bonjour Monsieur";
            return result;*/
            if (isFemale) return "Bonjour Madame";
            else return "Bonjour Monsieur";
        }

        public static int MultiplierPar2(int x)
        {
            return x * 2;
        }
    }
}
