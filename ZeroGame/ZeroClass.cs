using System;
using System.Collections.Generic;
using System.Threading;
namespace ZeroGame
{
    class Zero
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int BufferWidth { get; set; }
        public int BufferHeight { get; set; }

        public static List<Square> squares = new List<Square>();

        private char zero = '0';
        private bool isWinning = false;
        private GameText text;

        public Zero(int x, int y, int width, int height, string str = "ВЫХОД ->")
        {
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            this.PosX = x;
            this.PosY = y;
            this.BufferWidth = width;
            this.BufferHeight = height;
            text = new GameText(str);
        }

        private void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(this.PosX, this.PosY);
            Console.Write(zero);
        }
        private void MoveUp()
        {
            if (this.PosY - 1 <= 0)
            {
                return;
            }
            foreach (Square s in squares)
            {
                if ((this.PosY - 1 == s.PosY) && (this.PosX == s.PosX))
                {
                    return;
                }
            }
            this.PosY--;
        }
        private void MoveLeft()
        {
            if (this.PosX - 1 <= 0)
            {
                return;
            }
            foreach (Square s in squares)
            {
                if ((this.PosX - 1 == s.PosX) && (this.PosY == s.PosY))
                {
                    return;
                }
            }
            this.PosX--;
        }
        private void MoveDown()
        {
            if (this.PosY + 1 >= Console.BufferHeight)
            {
                return;
            }
            foreach (Square s in squares)
            {
                if ((this.PosY + 1 == s.PosY) && (this.PosX == s.PosX))
                {
                    return;
                }
            }
            this.PosY++;
        }
        private void MoveRight()
        {
            if (this.PosX + 1 >= Console.BufferWidth)
            {
                return;
            }
            foreach (Square s in squares)
            {
                if ((this.PosX + 1 == s.PosX) && (this.PosY == s.PosY))
                {
                    return;
                }
            }
            this.PosX++;
        }
        private void GetInput()
        {
            char input = Convert.ToChar(Console.ReadKey(true).KeyChar.ToString());

            switch (input)
            {
                case 'w':
                case 'ц':
                    MoveUp();
                    break;
                case 'a':
                case 'ф':
                    MoveLeft();
                    break;
                case 's':
                case 'ы':
                    MoveDown();
                    break;
                case 'd':
                case 'в':
                    MoveRight();
                    break;
                default:
                    break;
            }
        }
        private void CheckWin()
        {
            if (this.PosY >= text.PosY && this.PosX < 20)
            {
                this.isWinning = true;
            }
        }

        public void ChangeFrame(out bool breaker)
        {
            CheckWin();
            if(isWinning)
            {
                breaker = true;
            }
            else
            {
                breaker = false;
            }

            Draw();
            foreach (Square s in squares)
            {
                s.Draw();
            }
            text.TextDraw();
            GetInput();
        }
    }
}
