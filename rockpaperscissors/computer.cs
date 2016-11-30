using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Computer : Player  
    {
        Random Random = new Random();
        public override void PlayerChoice()
        {
            Random randomComputerChoice = new Random();
            int computerInput = randomComputerChoice.Next(0, 4);
            if(computerInput == 0)
            {
                chooseOption = "Rock";
            }
            else if (computerInput == 1)
            {
                chooseOption = "paper";
            }
            else if (computerInput == 2)
            {
                chooseOption = "Scissors";
            }
            else if (computerInput == 3)
            {
                chooseOption = "Lizard";
            }
            else if (computerInput == 4)
            {
                chooseOption = "Scissors";
            }
            else
            {
                
            }

            //string[] PlayerChoice = { "rock", "paper", "scissors", "spock", "lizard" };
            //int index = Random.Next(PlayerChoice.Length);
            //chooseOption = PlayerChoice[index];
        }
    }
}
