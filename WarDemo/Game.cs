using System;
using System.Collections.Generic;
using System.Text;

namespace WarDemo
{
    class Game
    {
        int playerOneScore;
        int playerTwoScore;
        Random rand;

        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            rand = new Random();
        }
        public int ChooseNumberOfSides()
        {
            Console.WriteLine("What size dice will you be using?");
            return int.Parse(Console.ReadLine());
        }
        
        public int RollDice(int numOfSides)
        {
            return rand.Next(numOfSides);
        }

        public void RunGame()
        {
            int num = ChooseNumberOfSides();
            while (playerOneScore < 3 && playerTwoScore < 3)
            {
                int playerOneRoll = RollDice(num);
                int playerTwoRoll = RollDice(num);
                CompareRolls(playerOneRoll, playerTwoRoll);
            }
            DisplayWinner();
        }

        public void CompareRolls(int playerOne, int playerTwo)
        {
            Console.WriteLine("Player One has " + playerOne + ". Player Two has " + playerTwo + ".");
            if(playerOne > playerTwo)
            {
                playerOneScore++;
                Console.WriteLine("Player One wins!");
            }
            else if (playerTwo > playerOne)
            {
                playerTwoScore++;
                Console.WriteLine("Player Two wins!");
            }
            else
            {
                Console.WriteLine("Tie round.");
            }
        }

        public void DisplayWinner()
        {
            if(playerOneScore > playerTwoScore)
            {
                Console.WriteLine("Player One wins the game!");
            }
            else
            {
                Console.WriteLine("Player Two wins the game!");
            }
        }

    }
}
