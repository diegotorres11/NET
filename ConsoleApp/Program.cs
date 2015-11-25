using System;

namespace ConsoleApp
{
    internal delegate void MyDelegate<T>(T argument);

    class Program
    {
        static void MainDelegate()
        {
            var myStringDelegate = new MyDelegate<string>(TakeString);
            var myIntDelefate = new MyDelegate<int>(TakeInt);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Action and Func delegate");

            var actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);

            actionTarget("Action message", ConsoleColor.Yellow, 5);

            var funcTarget = new Func<int, int, int>(Addition);

            Console.WriteLine(funcTarget.Invoke(10, 15));

            Console.ReadLine();
        }

        private static int Addition(int n1, int n2)
        {
            return n1 + n2;
        }

        private static void DisplayMessage(string msg, ConsoleColor consoleColor, int printCount)
        {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = consoleColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            Console.ForegroundColor = previous;
        }

        static void TakeString(string arg)
        {
            
        }

        static void TakeInt(int arg)
        {
            
        }
    }
}
