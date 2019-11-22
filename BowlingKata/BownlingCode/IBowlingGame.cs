
namespace BownlingCode
{
    public interface IBowlingGame
    {
        void roll(int pinsFirstRoll = 0, int pinsSecondRoll = 0);
        int score();
    }
}