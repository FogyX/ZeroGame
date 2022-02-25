using System;
using System.Collections.Generic;

namespace ZeroGame
{
    struct Square
    {
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Square(int x, int y)
        {
            this.PosX = x;
            this.PosY = y;
            Zero.squares.Add(this);
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.PosX, this.PosY);
            Console.Write('\u25A0');
        }
    }

}
