using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ZeroGame
{
    class Parser
    {
        private string path;

        public Parser(string path)
        {
            this.path = path;
        }

        private List<string[]> ParseFile()
        {
            IEnumerable<string> rawArray;
            List<string[]> result = new List<string[]>();

            rawArray = File.ReadLines(this.path);
            
            foreach (string str in rawArray)
            {
                string[] midResult = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                result.Add(midResult);
            }

            return result;
        }

        public void GenerateSquares()
        {
            foreach (string[] arr in this.ParseFile())
            {
                Zero.squares.Add(new Square(Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1])));
            }
        }
    }
}
