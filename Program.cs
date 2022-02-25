using System;
using System.Text;
using System.Threading;

namespace ZeroGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ZERO";
            Console.OutputEncoding = Encoding.Unicode;
            
            Thread.Sleep(1000);
            Console.Write("Привет! ");
            Thread.Sleep(2000);
            Console.Write("Нажми любую кнопку, чтобы продолжить. ");
            Thread.Sleep(2000);
            Console.WriteLine("Ну кроме кнопки выключения компа, конечно.");
            Thread.Sleep(1000);
            Console.ReadKey(true);

            Parser par = new Parser(@"SquaresList.txt");
            par.GenerateSquares();

            Zero zero = new Zero(10, 10, 40, 30);

            while (true)
            {
                bool breaking;
                zero.ChangeFrame(out breaking);

                if (breaking) break;
            }

            Console.Clear();
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("ВЫ ПОБЕДИЛИ! \n  А теперь иди отдыхать :3");
            Thread.Sleep(2000);
            Console.ReadKey(true);
        }
    }
}
