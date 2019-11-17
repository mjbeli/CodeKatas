using System;
using System.Collections.Generic;

namespace BownlingCode
{
    public class BowlingGame: IBowlingGame
    {
        private IList<int> _rolls = new List<int>(); // Tell, don't ask. Don't expose this atribute.

        public void roll(int pins)
        {
            if(pins < 0 || pins > 10)
                return;
        }
        
        public int score()
        {
            if(_rolls.Count == 0)
                return 0;

            return -1;
        }
    }
}
