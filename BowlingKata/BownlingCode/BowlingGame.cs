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
                        
            _rolls.Add(new FrameDTO(pinsFirstRoll, pinsSecondRoll));
        }
        
        public int score()
        {
            if(_rolls.Count == 0)
                return 0;

            return _rolls.Sum(q => q.getMySum());
        }
    }
}
