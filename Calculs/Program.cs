/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 * - Utilisez le débogueur de l'IDE et réalisez une exécution pas à pas pour mieux cerner l'origine des dysfonctionnements.
 * - Apportez les corrections nécessaires pour corriger les dysfonctionnements et obtenir les résultats attendus.
 * - Compléter le rapport d'incidents (téléchargeable ici), en expliquant l'origine des dysfonctionnements et les corrections apportées (extrait du rapport d'incidents ci-contre). Votre responsable vous a aussi demandé de présenter les différents possibilités de correcitons, lorsqu'il y en avait plusieurs et, dans ce cas, de justifier le choix effectué (la solution retenue). Les informations seront mémiorisées dans une banque de données, dans le cas où le même type de dysfonctionnement apparaîtrait dans d'autres tickets d'incidents.
 * - Rendre au client le projet corrigé et le rapport d'incidents complété (étape fictive) : le ticket d'incident est clôturé.
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilisateur
            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                choix = int.Parse(Console.ReadLine());
                // traitement des choix
                if (choix != 0)
                {
                    if (choix == 1)
                    {
                        // choix de l'addition
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        Console.Write(val1 + " + " + val2 + " = ");
                        reponse = int.Parse(Console.ReadLine());
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                    }
                    else
                    {
                        // choix de la multiplication
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        Console.Write(val1 + " x " + val2 + " = ");
                        reponse = int.Parse(Console.ReadLine());
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                    }
                }
            }
        }
    }
}
