using System;

namespace BownlingCode
{
    public class FrameDTO
    {
        private int _firstRoll;
        private int _secondRoll;

        public FrameDTO (int roll1, int roll2)
        {
        _firstRoll = roll1;
        _secondRoll = roll2;
        }
        
        public int getMySum() {return _firstRoll +_secondRoll;}
    }
}