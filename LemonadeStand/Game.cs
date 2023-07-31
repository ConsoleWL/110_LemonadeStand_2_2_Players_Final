﻿using System;
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

        public void GeneratePlayers(int numberOfPlayers)
        {
            for (int i = 1; i <= numberofPlayers; i++)
            {
                Console.WriteLine($"\nEnter a name for player {i}");
                string name = Console.ReadLine();

                if (name == "" || name == " " || name == "  ")
                {
                    players.Add(new Player());
                    players[i - 1].name = $"Player {i}";
                }
                else
                {
                    players.Add(new Player());
                    players[i - 1].name = name;
                }
            }
        }

        public void DisplayPlayers()
        {
            Console.WriteLine("\nList of players:");

            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"Player {i + 1}: {players[i].name}");
            }
        }

        public void Welcome()
        {
            Console.WriteLine("\nWelcome to Lemonade Stand!");
            Console.WriteLine("You have 7 days to make as much money as you can.");
            Console.WriteLine("The weather, along with your pricing, can affect your success.");
            Console.WriteLine("Can you make the big bucks");
            Console.WriteLine("Player with the biggest stack wins");
        }

        public void AnounceStartOftheDay()
        {
            Console.WriteLine("_________________________________________________");
            Console.WriteLine($"\nDay {currentDay} begins!");
        }

        public void WeatherChanger()
        {
            int changeWeather = UserInterface.GenerateRandom1to9();
            if (changeWeather < 3)
            {
                //then well change it
                if (days[currentDay - 1].weather.condition == "perfect")
                {
                    days[currentDay - 1].weather.condition = "bad";
                    days[currentDay - 1].weather.temperature = 50;
                    days[currentDay - 1].weather.predictedForecast = days[currentDay - 1].weather.weatherConditions[2];
                    days[currentDay - 1].weather.isWeatherChanged = true;
                }
                else if (days[currentDay - 1].weather.condition == "bad")
                {
                    days[currentDay - 1].weather.condition = "perfect";
                    days[currentDay - 1].weather.temperature = 80;
                    days[currentDay - 1].weather.predictedForecast = days[currentDay - 1].weather.weatherConditions[2];
                    days[currentDay - 1].weather.isWeatherChanged = true;
                }
                else
                {
                    days[currentDay - 1].weather.condition = "perfect";
                    days[currentDay - 1].weather.temperature = 80;
                    days[currentDay - 1].weather.predictedForecast = days[currentDay - 1].weather.weatherConditions[2];
                    days[currentDay - 1].weather.isWeatherChanged = true;
                }
            }
        }

        public void RunGame()
        {
            NumberOfPlayers();
            GeneratePlayers(numberofPlayers);
            DisplayPlayers();
        }
    }
}
