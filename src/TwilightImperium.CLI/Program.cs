using System;

namespace TwilightImperium.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine($"Cost of only unit is {game.Units[0].Cost}");
        }
    }
}
