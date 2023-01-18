using System;

namespace mission3
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome user to game
            //create game board array to store players choices
            //ask each player for choice
            //update game board array
            //print board by calling supporting method class
            //check for winner by calling method in supporting class


            //some sudo code
            //print welcome
            Console.WriteLine("Hello Users, Welcome to the game.");
            Console.WriteLine("Player 1, please enter your name: ");
            string p1 = Console.ReadLine();
            Console.WriteLine("Player 2, please enter your name: ");
            string p2 = Console.ReadLine();


            //print 2d array with all entries as _ (empty)
            //while (some board logic to determine if entries are consecutive) -> this could be weird, could be a more efficient way
            Console.WriteLine("The following board illustrates the positions you will select. \n");
            string currOut = "";

            //print the example board
            for (int i = 1; i <= 9; i++)
            {
                if( i % 3 == 0)
                {
                    currOut += $"{i} \n";
                } else
                {
                    currOut += i.ToString() + " ";
                }
            }

            Console.WriteLine(currOut);
            Console.WriteLine("Play ball! \n \n");



            //game functionality
            Console.WriteLine(p1 + ", please select a position");
            //print the empty board
            currOut = "";
            for (int i = 1; i <= 9; i++)
            {
                if (i % 3 == 0)
                {
                    currOut += $"_ \n";
                }
                else
                {
                    currOut += "_ ";
                }
            }

            Console.WriteLine(currOut);












        }
    }
}

