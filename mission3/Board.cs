using System;
using System.Drawing;

namespace mission3
{
	public class Board
	{
        //receive board array from driver class
        //contain method that prints board based on info passed in
        //contain method that receives game board aray as input and returns winner (if there was one)
        public void BoardFunctionality(string[] stringArray)
        {
            string currOut = "";
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
        }

		public bool[] WinCheck(string[] stringArray)
		{
            //Test for win Check
            bool[] win = new bool[2];
            win[0] = false;
            win[1] = false;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] != "-")
                {
                    switch (i)
                    {
                        case 0:
                            win = CheckWin("vertical", stringArray, i);
                            if (win[0] == true) { goto End; }
                            win = CheckWin("horizontal", stringArray, i);
                            if (win[0] == true) { goto End; }
                            win = CheckWin("diag", stringArray, i);
                            if (win[0] == true) { goto End; }
                            break;
                        case 1:
                            win = CheckWin("vertical", stringArray, i);
                            if (win[0] == true) { goto End; }
                            break;
                        case 2:
                            win = CheckWin("vertical", stringArray, i);
                            if (win[0] == true) { goto End; }
                            win = CheckWin("bdiag", stringArray, i);
                            if (win[0] == true) { goto End; }
                            break;
                        case 3:
                            win = CheckWin("horizontal", stringArray, i);
                            if (win[0] == true) { goto End; }
                            break;
                        case 6:
                            win = CheckWin("horizontal", stringArray, i);
                            if (win[0] == true) { goto End; }
                            break;
                    }
                }
            }
            return win;
        //End Test
        End:
            return win;
        }


        public bool[] CheckWin(string checkType, string[] board, int pos)
		{
            bool[] winResult = new bool[2];
			if (checkType == "horizontal")
			{
				// Compares a row of the board
				if ((board[pos] == board[pos + 1]) & (board[pos] == board[pos + 2]))
				{
                    winResult[0] = true;
                    if (board[pos] == "X")
                    {
                        winResult[1] = true;
                    }
                    else
                    {
                        winResult[1] = false;
                    }
					return winResult;
				}
				else
                {
                    winResult[0] = false;
                    return winResult;
                }
			}
			else if (checkType == "vertical")
			{
				// compares a column of the board
                if ((board[pos] == board[pos + 3]) & (board[pos] == board[pos + 6]))
                {
                    winResult[0] = true;
                    if (board[pos] == "X")
                    {
                        winResult[1] = true;
                    }
                    else
                    {
                        winResult[1] = false;
                    }
                    return winResult;
                }
                else
                {
                    winResult[0] = false;
                    return winResult;
                }
            }
			else if (checkType == "diag")
			{
                // compares a column of the board
                if ((board[pos] == board[pos + 4]) & (board[pos] == board[pos + 8]))
                {
                    winResult[0] = true;
                    if (board[pos] == "X")
                    {
                        winResult[1] = true;
                    }
                    else
                    {
                        winResult[1] = false;
                    }
                    return winResult;
                }
                else
                {
                    winResult[0] = false;
                    return winResult;
                }
            }
            else if (checkType == "bdiag")
            {
                // compares a column of the board
                if ((board[pos] == board[pos + 2]) & (board[pos] == board[pos + 6]))
                {
                    winResult[0] = true;
                    if (board[pos] == "X")
                    {
                        winResult[1] = true;
                    }
                    else
                    {
                        winResult[1] = false;
                    }
                    return winResult;
                }
                else
                {
                    winResult[0] = false;
                    return winResult;
                }
            }
            else
            {
                winResult[0] = false;
                return winResult;
            }
		}
	}
}

