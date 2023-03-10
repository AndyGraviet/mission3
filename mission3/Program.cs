using System;
using System.Collections.Generic;

namespace mission3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Board Variable
            Board board = new Board();
            //Set Win Variable to False
            bool[] WinCondition = new bool[2];
            WinCondition[0] = false;
            WinCondition[1] = false;
            //print welcome
            Console.WriteLine("Hello Users, Welcome to the game.");
            Console.WriteLine("Player 1, please enter your name: ");
            string p1 = Console.ReadLine();
            Console.WriteLine("Player 2, please enter your name: ");
            string p2 = Console.ReadLine();


            //print 2d array with all entries as _ (empty)
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





            //declare game array, initial values are all -

            currOut = "";

            string[] stringArray = new string[9];
            for (int i=0; i < stringArray.Length; i++)
            {
                stringArray[i] = "-";
            }

            
            for (int i = 0; i < stringArray.Length; i++)
            {
                if ((i + 1) % 3 == 0)
                {
                    currOut += $"{stringArray[i]} \n";
                }
                else
                {
                    currOut += stringArray[i] + " ";
                }
            }

            Console.WriteLine(currOut);





            //while winning combination is not found, continue playing
            //plan here is to do a list of lists and then check if a list of the users selected elements can be found here
            //this probably wont' work
            List<List<int>> myList = new List<List<int>>();
            myList.Add(new List<int> { 1, 2, 3 });
            myList.Add(new List<int> { 4, 5, 6 });
            myList.Add(new List<int> { 7, 8, 9 });
            myList.Add(new List<int> { 1, 4, 7 });
            myList.Add(new List<int> { 2, 5, 8 });
            myList.Add(new List<int> { 3, 6, 9 });
            myList.Add(new List<int> { 7, 5, 3 });
            myList.Add(new List<int> { 1, 5, 9 });




            int count = 0;
            while (count < 9 & WinCondition[0] == false)
            {
                WinCondition = board.WinCheck(stringArray);
                if (WinCondition[0] == true) { goto EndOfGame; }

                int currPos = 0;

                
                Console.WriteLine(p1 + ", please select a position");
                currPos = int.Parse(Console.ReadLine());

                while (stringArray[currPos - 1] != "-")
                {
                    Console.WriteLine(p1 + " This position is taken, please select another");
                    currPos = int.Parse(Console.ReadLine());
                }

                stringArray[currPos - 1] = "X";
                //increase count and print board
                count++;
                board.BoardFunctionality(stringArray);



                //repeat process for 2nd player
                WinCondition = board.WinCheck(stringArray);
                if (WinCondition[0] == true) { goto EndOfGame; }
                Console.WriteLine(p2 + ", please select a position");
                currPos = int.Parse(Console.ReadLine());


                while (stringArray[currPos - 1] != "-")
                {
                    Console.WriteLine(p2 + " This position is taken, please select another");
                    currPos = int.Parse(Console.ReadLine());
                }

                stringArray[currPos - 1] = "O";
                count++;
                board.BoardFunctionality(stringArray);
            }



        //Prints winner of game
        EndOfGame:
            {
                if (WinCondition[0] == true)
                {
                    string winnerName = "";
                    if (WinCondition[1] == true)
                    {
                        winnerName = p1;
                    }
                    else
                    {
                        winnerName = p2;
                    }

                    Console.WriteLine(winnerName + " has won, Congrats!");
                }
            }


            //done with loop
            

















        }
    }
}

