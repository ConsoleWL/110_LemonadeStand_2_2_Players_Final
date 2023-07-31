using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Game
    {
        int currentDay;
        int numberofPlayers;
        List<Player> players;
        List<Day> days;
        Store store;
        Player playerWinner;

        public Game()
        {
            currentDay = 1;
            players = new List<Player>();
            store = new Store();
            days = new List<Day>
            {
                new Day(),
                new Day(),
                new Day(),
                new Day(),
                new Day(),
                new Day(),
                new Day()
            };
            playerWinner = new Player();
        }

        public int NumberOfPlayers()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter number of Players: 1, 2 , 3 , 4 , 5 :");

                    numberofPlayers = Convert.ToInt32(Console.ReadLine());

                    if (numberofPlayers > 0 && numberofPlayers <= 5)
                    {
                        return numberofPlayers;
                    }
                    else
                    {
                        Console.WriteLine("\nChoose beetween 1 and 5:");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nWrong input, must be an interger");
                }
            }
        }

        public void RunGame()
        {

        }
    }
}
