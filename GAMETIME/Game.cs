using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMETIME
{
    class Game
    {
        //members varaibles
        public List<string> ChooseGestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        public Player player1;
        public Player player2;
        // private int GetNumbersOfPlayers;



        

        
        
       

        // Constructor

        public Game()
        {
            
           //  GetNumbersOfPlayers = GetNumberOfPlayers();

        }


        // members methods
        public void RunGame()
        {
            settingUpPlayers();

            player1.ChooseGesture();
            player2.ChooseGesture();
            
        }

        public void settingUpPlayers()
        {
            int numberOfPlayers = GetNumberOfPlayers();
            if (numberOfPlayers == 1) 
            {
                player1 = new Human_Player();
                player2 = new CPU_Player();
            }
            else
            {
                player1 = new Human_Player();
                player2 = new Human_Player();
            }
            Console.WriteLine("Player1 please choose gesture rock, paper, scissors, lizard, spock");
            player1.gesture= Console.ReadLine();
           
            
            {

               if (player1.gesture == "rock")
                {

                }
               if (player2.gesture == "scissors")
                {

                }

                
              // Console.WriteLine("Rock smashs scissors to dust");
                //if()
            }
        }

        private int GetNumberOfPlayers()
        {
            Console.WriteLine("How many Players");
            // Console.ReadLine();
            int result = int.Parse(Console.ReadLine());
            return result;
        }
    }
}
