using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class GameAccount
    {
        
        public string GamesCount { get; }
        public string UserName { get;}
        public int GameIndex
        {
            get
            {
                int index = 0;
                foreach (var item in allRating)
                {
                    index += item.Amount;
                }
                return index;
            }
        }
        public int CurrentRating 
        {
            get
            {
                int rating = 5;
                foreach (var item in allRating)
                {
                    rating += item.Amount;
                }
                return rating;
            }
        }

        public GameAccount(string name)
        {
            UserName = name;
           int  count = 0;
        }

        private List<CalcuRating> allRating = new List<CalcuRating>();

       public void WinGame(string oponnent, int rating )
        {
            if (rating <= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Amount of deposit must be positive");
            }
            var winGame = new CalcuRating(1, oponnent, "Win" , rating);
            allRating.Add(winGame);
        }

        public void LoseGame( string oponnent, int rating )
        {
            if (rating <= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating must be positive");
            }
            if(CurrentRating - rating < 0)
            {
                throw new InvalidOperationException("Rating must be positive");
            }
            var loseGame = new CalcuRating(1, oponnent, "Lose", -rating);
            allRating.Add(loseGame);
        }

        public string GetStats()
        {
            var report = new System.Text.StringBuilder();

            int currentRating = 20;
            int index = 0;
            report.AppendLine("#\tName\tOpponent\tRating\tNote\tAmount");
            foreach (var item in allRating)
            {
                currentRating += item.Amount;
                index += item.GameIndex;
                report.AppendLine($"{index}\t{UserName}\t{item.Opponent}\t\t{currentRating}\t{item.Notes}\t{item.Amount}");
            }
            return report.ToString();
        }
    }
}
