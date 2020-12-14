using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Engine
    {
        private Square[,] board = new Square[3, 3];

        public void PlayGame()
        {
            Player player = Player.Crosses;

            bool flag = true;
            while (flag)
            {
                DisplayBoard();
                flag = PlayMove(player);
                if (!flag)
                {
                    return;
                }
                player = 3 - player;
            }
        }
        private void DisplayBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + board[i,j]);
                }
                Console.WriteLine();
            }
        }
        private bool PlayMove(Player player)
        {
            Console.WriteLine("Invalid input quits game");
            Console.WriteLine($"{player}: Enter coordinates eg. 2,2 >");
            string input = Console.ReadLine();
            string[] coordinates = input.Split(',');

            if (coordinates.Length != 2)
                return false;
            int.TryParse(coordinates[0], out int row);
            int.TryParse(coordinates[1], out int column);

            if (row < 1 || row > 3 || column < 1 || column > 3)
                return false;
            if (board[row - 1, column - 1].Owner != Player.None)
            {
                Console.WriteLine("Board occupied !");
                return false;
            }
            board[row - 1, column - 1] = new Square(player);
            return true;

        }
    }
}
