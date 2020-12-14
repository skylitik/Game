using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum Player
    {
        None = 0,
        Crosses,
        Noughts
    }
    public struct Square
    {
        public Square(Player owner)
        {
            Owner = owner;
        }
        public Player Owner { get; }

        public override string ToString()
        {
            switch (Owner)
            {
                case Player.None:
                    return ".";
                case Player.Crosses:
                    return "X";
                case Player.Noughts:
                    return "O";
                default:
                    throw new Exception("Invalid value");
            }
        }
    }

}
