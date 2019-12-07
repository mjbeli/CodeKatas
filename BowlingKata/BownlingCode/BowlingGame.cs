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
                if(!f.isSpare() && !f.isStrike())
                    myCurrentScore += f.getMySum();
                if(f.isStrike() && i != _rolls.Count)
                    myCurrentScore += calculateStrikePoints(i-1);
                if(f.isSpare() && i != _rolls.Count) // The next roll is registered.
                    myCurrentScore += f.getMySum() + _rolls[i].getSpareSum();                    
            }
            
            return myCurrentScore;
        }

        private int calculateStrikePoints(int pos)
        {
            if(pos >= _rolls.Count) // There isn't more rolls
                return 0;
            
            // if next roll is a strike, need to wait until next frame.
            if(_rolls[pos + 1].isStrike() && pos + 2 >= _rolls.Count) 
                return 0;

            if(_rolls[pos + 1].isStrike())
                return _rolls[pos].getStrikeSum() + _rolls[pos + 1].getStrikeSum() + _rolls[pos + 2].getSpareSum();
            else
                return _rolls[pos].getStrikeSum() + _rolls[pos + 1].getMySum();           
        }
    }
}
