using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Game
    {
        public readonly GameAccount User1;
        public readonly GameAccount User2;
        public int Rating { get; }
        public Game(int rating, GameAccount user1, GameAccount user2 )
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "The rating for which they are playing cannot be negative");
            }
            User1 = user1;
            User2 = user2;
            Rating = rating;
        }

        public void Play() 
        {
            
        Random rnd = new Random();
            int answer = rnd.Next(0, 2);
            int answUser1 = rnd.Next(0, 2);
            int answUser2 = rnd.Next(0, 2);


            if (answUser1 == answer)
            {
                User1.WinGame(User2.UserName, Rating);
                User2.LoseGame(User1.UserName, Rating);

            }
            else if (answUser2 == answer)
            {
                User2.WinGame(User1.UserName, Rating);
                User1.LoseGame(User2.UserName, Rating);

            }
            else if (answUser1 == answer && answUser2 == answer)
            {
                User1.WinGame(User1.UserName, Rating);
                User2.WinGame(User2.UserName, Rating);

            }

        }
    }
}
