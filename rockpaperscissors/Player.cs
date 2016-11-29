using System;
namespace rockpaperscissors
{
    public class Player
    {

        public string chooseOption;
        public int playerScore;
        public Player()
        {
            this.chooseOption = chooseOption; // i don't know what how to do this
            this.playerScore = playerScore;
           
        }
        public virtual void PlayerChoice()
        {
            Console.WriteLine("Your choices are Rock, Paper, Scissors, Spock, Lizard");
            Console.WriteLine("Please type in your choice");
            chooseOption = Console.ReadLine();
            return chooseOption;
        }
    }
}