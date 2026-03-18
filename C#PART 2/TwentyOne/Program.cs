using System;
namespace TwentyOne
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Grand-Hotel and Casino.  Lets start by telling me your name");
            string playerName = Console.ReadLine();

            Console.WriteLine("And How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", PlayerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" )
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOne();
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance >0)
                {
                    game.Play(); 
                }
                game -= player;
                Console.WriteLine("Thanks for Playing!");
            }
            Console.WriteLine("Feel free to look around the casino . Bye for now.");
            Console.Read();


        }
    }
}