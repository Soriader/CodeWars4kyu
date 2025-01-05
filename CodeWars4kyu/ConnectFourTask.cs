using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars4kyu
{
	public class ConnectFourTask
	{
		public static string WhoIsWinner(List<string> piecesPositionList)
		{
			int rows = 6;
			int cols = 7;
			string[,] board = new string[rows, cols];

			Dictionary<string, int> columnMapping = new Dictionary<string, int>()
	{
		{ "A", 0 },
		{ "B", 1 },
		{ "C", 2 },
		{ "D", 3 },
		{ "E", 4 },
		{ "F", 5 },
		{ "G", 6 }
	};

			foreach (var move in piecesPositionList)
			{
				string[] splitMove = move.Split('_');
				string column = splitMove[0];
				string color = splitMove[1];

				int col = columnMapping[column];
				int row = GetAvailableRow(board, col);

				if (row != -1)
				{
					board[row, col] = color;

					if (CheckWinner(board, row, col, color))
					{
						return color;
					}
				}
			}

			return "Draw";
		}

		private static int GetAvailableRow(string[,] board, int col)
		{
			for (int row = 5; row >= 0; row--)
			{
				if (board[row, col] == null)
				{
					return row;
				}
			}
			return -1;
		}

		private static bool CheckWinner(string[,] board, int row, int col, string color)
		{
			if (CheckDirection(board, row, col, color, 1, 0)) return true;
			if (CheckDirection(board, row, col, color, 0, 1)) return true;
			if (CheckDirection(board, row, col, color, 1, 1)) return true;
			if (CheckDirection(board, row, col, color, 1, -1)) return true;

			return false;
		}

		private static bool CheckDirection(string[,] board, int row, int col, string color, int rowDir, int colDir)
		{
			int count = 1;

			count += CountInDirection(board, row, col, color, rowDir, colDir);
			count += CountInDirection(board, row, col, color, -rowDir, -colDir);

			return count >= 4;
		}

		private static int CountInDirection(string[,] board, int row, int col, string color, int rowDir, int colDir)
		{
			int count = 0;
			int r = row + rowDir;
			int c = col + colDir;

			while (r >= 0 && r < 6 && c >= 0 && c < 7 && board[r, c] == color)
			{
				count++;
				r += rowDir;
				c += colDir;
			}

			return count;
		}
	}
}
//https://www.codewars.com/kata/56882731514ec3ec3d000009/train/csharp