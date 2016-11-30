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
            

            //switch (chooseOption)
            //{
            //    case 1:
            //        Console.WriteLine("Rock");
            //        break;
            //    case 2:
            //        Console.WriteLine("Paper");
            //        break;
            //    case 3:
            //        Console.WriteLine("Scissors");
            //        break;
            //    case 4:
            //        Console.WriteLine("Lizard");
            //        break;
            //    case 5:
            //        Console.WriteLine("Spock");
            //    break;
            //    default:
            //    Console.WriteLine("Invalid input. Try (1) Rock, (2) Paper, (3) Scissors, (4) Lizard, or (5) Spock");
            //    break;
            }
      }
}
