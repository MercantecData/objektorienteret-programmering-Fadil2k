using System;

namespace GuessANumber
{
    public class GenNumber
    {
        public static int Random(int min, int max)
        {
            var rnd = new Random();
            return rnd.Next(min, max);
        }
    }
}