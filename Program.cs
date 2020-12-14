using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine ticTacToe = new Engine();
            ticTacToe.PlayGame();
            Console.WriteLine("Game over");
        }
    }
}
