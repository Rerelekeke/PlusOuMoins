using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOuMoins
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random rand = new System.Random();
            int nbSearched = rand.Next(101);
            string userValue = "";
            int integer = 0;
            Console.WriteLine("Bienvenu au jeu du Plus ou Moins, essayez de deviner le nombre en question compris entre 0 et 100");
            do
            {
                Console.WriteLine("entrez un nombre:");
                userValue = Console.ReadLine();
                if (!int.TryParse(userValue, out integer))
                {
                    Console.WriteLine("ERROR conversion failed");
                    continue;
                }
                if (integer > nbSearched)
                { Console.WriteLine("MOINS"); }
                else if (integer < nbSearched){ Console.WriteLine("PLUS"); }

            }
            while (integer != nbSearched);

            Console.WriteLine("Bien joué!! Vous avez gagnez");
        }
    }
}
