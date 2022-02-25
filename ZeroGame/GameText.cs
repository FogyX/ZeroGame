using System;

namespace ZeroGame
{
    class GameText
    {
        public string text;
        public int PosX = 5;
        public int PosY = 25;

        public GameText(string text)
        {
            this.text = text;
        }

        public void TextDraw()
        {
            Console.SetCursorPosition(this.PosX, this.PosY);
            Console.Write(text);
        }
    }
}
