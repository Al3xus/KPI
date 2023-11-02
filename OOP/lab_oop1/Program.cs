using System;

namespace lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p1 = new GameAccount("First");
            var p2 = new GameAccount("Second");

            p1.WinGame(p2.UserName, 40);
            p2.LoseGame(p1.UserName, 40);

            p1.LoseGame(p2.UserName, 25);
            p2.WinGame(p1.UserName, 25);

            p1.LoseGame(p2.UserName, 180);
            p2.WinGame(p1.UserName, 180);

            Console.WriteLine(p1.GetStats());
            Console.WriteLine(p2.GetStats());
        }
    }
}       