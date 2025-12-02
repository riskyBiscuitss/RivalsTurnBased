using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RivalsTurnBased
{
    internal class GameBoard
    {
        public int[,] BoardArray { get { return boardArray; } set { boardArray = value; }  }
        private int[,] boardArray = new int [7, 5];

       // public int[,] InnerBoardArray { get { return innerBoardArray; } set { innerBoardArray = value; } }
        //private int[,] innerBoardArray = new int[3, 3];
        public void DisplayGameBoard()
        {
            for(int i = 0; i < BoardArray.GetLength(0); i++)
            {
                for (int k = 0; k < 6; k++)
                {
                    Console.WriteLine();
                }

                for(int j = 0; j < BoardArray.GetLength(1); j++)
                {
                    Console.Write($"{i}{j}                                         ");
                }
            }
        }
    }
}
