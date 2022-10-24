using System;


namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new GameAccount("Lol");
            var user2 = new GameAccount("Kek");
            var game = new Game(5, user1, user2);
            game.Play();
            game.Play();
            game.Play();
            game.Play();
            game.Play();
            Console.WriteLine(user1.GetStats());
            Console.WriteLine(user2.GetStats());
        }

    }
}
