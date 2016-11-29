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
            string[] PlayerChoice = { "rock", "paper", "scissors", "spock", "lizard" };
            int index = Random.Next(PlayerChoice.Length);
            chooseOption = PlayerChoice[index];
        }
    }
}
