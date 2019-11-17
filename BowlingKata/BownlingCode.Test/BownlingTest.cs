using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BownlingCode.Test
{
    [TestClass]
    public class BownlingTest
    {
        private IBowlingGame _myGame;

        // Run before each test
        [TestInitialize]
        public void generateNewGame ()
        {
            _myGame = new BowlingGame();
        }

        [TestMethod]
        public void ShowBasicScore()
        {
            Assert.IsTrue(_myGame.score() == 0);            
        }

        [TestMethod]
        public void NotAllowedPinsInASingleRollTest()
        {            
            _myGame.roll(12);
            _myGame.roll(-3);
            Assert.IsTrue(_myGame.score() == 0);
        }
    }
}
