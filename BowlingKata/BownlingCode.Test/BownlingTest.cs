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
        public void ShowInitialScore()
        {
            Assert.IsTrue(_myGame.score() == 0);            
        }

        [TestMethod]
        public void NotAllowedPinsTest()
        {            
            _myGame.roll(12);
            _myGame.roll(-3);     
            _myGame.roll(3, 11);
            _myGame.roll(4, -2);       
            Assert.IsTrue(_myGame.score() == 0);
        }

        [TestMethod]
        public void AddIncorrectFrame()
        {            
            _myGame.roll(6, 7);
            Assert.IsTrue(_myGame.score() == 0);
        }

        [TestMethod]
        public void JustFewSimpleRolls()
        {
            _myGame.roll(7);
            Assert.IsTrue(_myGame.score() == 7);  
            _myGame.roll(3, 2);
            Assert.IsTrue(_myGame.score() == 12);  
            _myGame.roll(6, 2);
            Assert.IsTrue(_myGame.score() == 20);              
        }

        
    }
}
