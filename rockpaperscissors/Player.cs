using System;
namespace rockpaperscissors
{
    public class Player
    {

        public string chooseOption;
        public int playerScore = 0;
        public string playerChoice;


        public Player()
        {
            
           
        }
        public virtual void PlayerChoice()
        {
            Console.WriteLine("If this shows up something is wrong.(player.cs)");
           // return chooseOption;
        }
    }
}