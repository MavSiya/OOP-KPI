using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class CalcuRating
    {
       public int Amount { get; }
        public string Opponent { get; }
        public string Notes { get; }
        public int GameIndex { get; }


        public CalcuRating(int index, string oponnent,string note, int rating )
        {
            GameIndex = index;
            Amount = rating;
            Opponent = oponnent;
            Notes = note;
        }

    }
}
