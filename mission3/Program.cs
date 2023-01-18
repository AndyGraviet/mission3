﻿using System;
using System.Collections.Generic;

namespace mission3
{
    class Program
    {
        static void Main(string[] args)
        {
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
            while (count < 9)
            {

                int currPos = 0;

                
                Console.WriteLine(p1 + ", please select a position");
                currPos = int.Parse(Console.ReadLine());

                while (stringArray[currPos - 1] != "-")
                {
                    Console.WriteLine(p1 + " This position is taken, please select another");
                    currPos = int.Parse(Console.ReadLine());
                }

                stringArray[currPos - 1] = "X";
                //input position to array
                currOut = "";
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
                count++;

                //another little check here
                if (count == 9)
                {
                    currOut = "";
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
                    break;
                }

                Console.WriteLine(currOut);


                //repeat process for 2nd player
                Console.WriteLine(p2 + ", please select a position");
                currPos = int.Parse(Console.ReadLine());


                while (stringArray[currPos - 1] != "-")
                {
                    Console.WriteLine(p2 + " This position is taken, please select another");
                    currPos = int.Parse(Console.ReadLine());
                }

                stringArray[currPos - 1] = "O";
                currOut = "";
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
                count++;
                Console.WriteLine(currOut);
            }


            //done with loop
            


            


















        }
    }
}

