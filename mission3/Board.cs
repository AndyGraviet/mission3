using System;
namespace mission3
{
	public class Board
	{
		public static void BoardFunctionality()
		{
			//receive board array from driver class
			//contain method that prints board based on info passed in
			//contain method that receives game board aray as input and returns winner (if there was one)
		}


		public bool CheckWin(string checkType, string[] board, int pos)
		{
			if (checkType == "horizontal")
			{
				// Compares a row of the board
				if ((board[pos] == board[pos + 1]) & (board[pos] == board[pos + 2]))
				{
					return true;
				}
				else { return false; }
			}
			else if (checkType == "vertical")
			{
				// compares a column of the board
                if ((board[pos] == board[pos + 3]) & (board[pos] == board[pos + 6]))
                {
                    return true;
                }
                else { return false; }
            }
			else if (checkType == "diag")
			{
                // compares a column of the board
                if ((board[pos] == board[pos + 4]) & (board[pos] == board[pos + 8]))
                {
                    return true;
                }
                else { return false; }
            }
            else if (checkType == "bdiag")
            {
                // compares a column of the board
                if ((board[pos] == board[pos + 2]) & (board[pos] == board[pos + 6]))
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }
		}
	}
}

