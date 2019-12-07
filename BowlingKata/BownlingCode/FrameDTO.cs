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
        
        public bool isSpare ()
        {
            return _firstRoll + _secondRoll == 10 && _firstRoll != 10;
        }

        public bool isStrike ()
        {
            return _firstRoll == 10;
        }

        public int getSpareSum()
        {
            return _firstRoll;
        }

        public int getStrikeSum()
        {
            return _firstRoll +_secondRoll;
        }
        public int getMySum() 
        { 
            return _firstRoll + _secondRoll;
        }
    }
}