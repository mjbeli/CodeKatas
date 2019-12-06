using System;
using System.Linq;
using System.Collections.Generic;

namespace BownlingCode
{
    public class BowlingGame: IBowlingGame
    {
        private IList<FrameDTO> _rolls = new List<FrameDTO>(); // Tell, don't ask. Don't expose this atribute.

        public void roll(int pinsFirstRoll = 0, int pinsSecondRoll = 0)
        {
            if(pinsFirstRoll < 0 || pinsFirstRoll > 10 || 
                pinsSecondRoll < 0 || pinsSecondRoll > 10 ||
                pinsFirstRoll + pinsSecondRoll > 10)
                return;

            if(_rolls.Count == 10)            
                return;

            _rolls.Add(new FrameDTO(pinsFirstRoll, pinsSecondRoll));
        }
        
        public int score()
        {
            int myCurrentScore = 0;

            if(_rolls.Count == 0)
                return myCurrentScore;

            for (int i = _rolls.Count ; i > 0 ; i--)
            { 
                FrameDTO f = _rolls[i-1];
                if(!f.isSpare())
                    myCurrentScore += f.getMySum();
                if(f.isSpare() && i != _rolls.Count) // The next roll is registered.
                    myCurrentScore += f.getMySum() + _rolls[i].getSpareSum();                    
            }
            
            return myCurrentScore;
        }
    }
}
