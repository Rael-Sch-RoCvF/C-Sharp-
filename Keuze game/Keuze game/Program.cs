using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamer_Keuze_Tekst_Game
{
    internal class Keuze
    {
        String[] Interaction =
        {
            "Toilet",
            "Upstairs",
            "Kitchen"
        };

        void InteractionPrompts()
        {
            for (int i = 0; i < Interaction.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {Interaction[i]}");
            }

        }

        static void Main(string[] args)
        {
            Keuze choices = new Keuze();
            Console.WriteLine("Choose where you want to go: ");
            choices.InteractionPrompts();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                default:
                    Console.WriteLine($"You go into the {choices.Interaction[choice - 1]}.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
