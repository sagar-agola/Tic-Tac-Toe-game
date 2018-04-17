using System;

namespace Tic_Tac_Toe_App
{
    public class Board
    {
        String [,] board = new String [3, 3];

        public Board(String[,] _board)
        {
            Array.Copy (_board, 0, board, 0,_board.Length);
        }

        public Char CheckWinner(String[,] Board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Board [i,0] == "X" && Board [i,1] == "X" && Board [i,2] == "X")
                    return 'x';
                else if (Board [i,0] == "O" && Board [i,1] == "O" && Board [i,2] == "O")
                    return 'o';
                else if (Board [0,i] == "X" && Board [1,i] == "X" && Board [2,i] == "X")
                    return 'x';
                else if (Board [0,i] == "O" && Board [1,i] == "O" && Board [2,i] == "O")
                    return 'o';
            }
            if (Board [0,0] == "X" && Board [1,1] == "X" && Board [2,2] == "X")
                return 'x';
            if (Board [0,0] == "O" && Board [1,1] == "O" && Board [2,2] == "O")
                return 'o';
            if (Board [0,2] == "X" && Board [1,1] == "X" && Board [2,0] == "X")
                return 'x';
            if (Board [0,2] == "O" && Board [1,1] == "O" && Board [2,0] == "O")
                return 'o';

            return 'n';
        }
    }
}
