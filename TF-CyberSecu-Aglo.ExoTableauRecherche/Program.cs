using System;

namespace TF_CyberSecu_Aglo.ExoTableauRecherche
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tableau = new string[] {
                "Jean",         //0
                "Jason",        //1
                "Lucas",        //2
                "Alexandre",    //3
                "Jean",         //4
                "Soussi",       //5
                "Philippe",     //6
                "Arélien",      //7
                "Eric",         //8
                "Cedrick",      //9
                "Raphael",      //10
                "Dorian" };     //11

            Console.WriteLine("Veuillez entrer un nom : ");
            string nomChoisi = Console.ReadLine();
            string message = $"Le nom {nomChoisi} est en position :";
            bool trouve = false;

            for (int i = 0; i < tableau.Length; i++)
            {
                if (nomChoisi == tableau[i])
                {
                    message += i + " ";
                    trouve = true;
                }
            }
            if (!trouve) message = $"Le nom {nomChoisi} n'est pas dans le tableau.";
            Console.WriteLine(message);
        }
    }
}
