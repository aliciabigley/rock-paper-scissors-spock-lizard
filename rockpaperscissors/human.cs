using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Human : Player
    {
        public override void PlayerChoice()
        {
            Console.WriteLine("Please enter Rock, Paper, Scissors, Spock, or Lizard");
            chooseOption = Console.ReadLine();
            switch (chooseOption)
            {
                case "Rock":
                case "Paper":
                case "Scissors":
                case "Spock":
                case "Lizard":
                break;
                default:
                Console.WriteLine("Invalid input. Try Rock, Paper, Scissors, Spock, or Lizard ");
                break;
            }
        }
    }
}
