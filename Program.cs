using System;

namespace Matches_Game
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Initialization

            var rand = new Random();
            Console.WriteLine("Combien d'allumettes voulez vous pour jouer ?");
            int nbAllumettes = Convert.ToInt32(Console.ReadLine());
            int nbAllumettesRestantes = nbAllumettes;

            for (int i = 0; i < nbAllumettes; i++)
                Console.Write("|");
            Console.Write("\n");

            while (nbAllumettesRestantes > 0)
            {
                //Player Turn

                Console.WriteLine("Combien d'allumettes voulez vous prendre ? (1-3)");
                int choixJoueur = Convert.ToInt32(Console.ReadLine());
                if (choixJoueur > 0 && choixJoueur < 4)
                {
                    nbAllumettesRestantes -= choixJoueur;
                    Console.WriteLine("Vous avez retiré {0} allumette(s).", choixJoueur);
                    for (int i = 0; i < nbAllumettes - nbAllumettesRestantes; i++)
                        Console.Write(" ");
                    for (int i = 0; i < nbAllumettesRestantes; i++)
                        Console.Write("|");
                    Console.Write("\n");
                }
                else
                {
                    Console.WriteLine("Veuillez choisir un nombre valide d'allumettes.");
                    continue;
                }

                if (nbAllumettesRestantes == 0)
                {
                    Console.WriteLine("Vous avez perdu !");
                    break;
                }

                    //CPU Turn

                int choixOrdinateur = 0;
                if (nbAllumettesRestantes <= 4 && nbAllumettesRestantes > 1)
                    choixOrdinateur = nbAllumettesRestantes - 1;
                else if (nbAllumettesRestantes == 1)
                    choixOrdinateur = 1;
                else
                    choixOrdinateur = rand.Next(1, 3);
                Console.WriteLine("L'ordinateur à retiré {0} allumette(s).", choixOrdinateur);
                nbAllumettesRestantes -= choixOrdinateur;
                for (int i = 0; i < nbAllumettes - nbAllumettesRestantes; i++)
                    Console.Write(" ");
                for (int i = 0; i < nbAllumettesRestantes; i++)
                    Console.Write("|");
                Console.Write("\n");
                if (nbAllumettesRestantes == 0)
                {
                    Console.WriteLine("Vous avez gagné !");
                    break;
                }
            }
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}