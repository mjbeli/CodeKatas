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
        public void MoreThan10Rolls()
        {            
            _myGame.roll(1, 1);
            Assert.IsTrue(_myGame.score() == 2);
            _myGame.roll(1, 1);
            _myGame.roll(1, 1);
            _myGame.roll(1, 1);
            _myGame.roll(1, 1);
            _myGame.roll(1, 1);
            _myGame.roll(1, 1);
            _myGame.roll(1, 1);
            _myGame.roll(1, 1);
            _myGame.roll(1, 1); // This is the 10th roll, my score should be 20
            _myGame.roll(1, 1); // illegal roll.
            _myGame.roll(1, 1); // illegal roll.
            Assert.IsTrue(_myGame.score() == 20);
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

        [TestMethod]
        public void SpareAndNextRollNotInformed()
        {
            _myGame.roll(7,3);
            Assert.IsTrue(_myGame.score() == 0);              
        }

        [TestMethod]
        public void SpareAndNextRollInformed()
        {
            _myGame.roll(7,3); // spare!
            _myGame.roll(3,4);
            Assert.IsTrue(_myGame.score() == 20);    
            _myGame.roll(2,8); // spare!          
            _myGame.roll(5,1);
            Assert.IsTrue(_myGame.score() == 41);    
        }

        [TestMethod]
        public void StrikeAndNextRollNotInformed()
        {
            _myGame.roll(10); // strike!
            Assert.IsTrue(_myGame.score() == 0);                
        }
        
        [TestMethod]
        public void StrikeAndNextRollInformed()
        {
            _myGame.roll(10); // strike!
            _myGame.roll(3,4);
            Assert.IsTrue(_myGame.score() == 24);                                      
        }

        [TestMethod]
        public void ConcatStrikesNotFinish()
        {                           
            _myGame.roll(10); // strike!
            _myGame.roll(10); // strike!
            Assert.IsTrue(_myGame.score() == 0);
        }

        [TestMethod]
        public void ConcatStrikes()
        {                           
            _myGame.roll(10); // strike!
            _myGame.roll(10); // strike!
            _myGame.roll(3,5);
            Assert.IsTrue(_myGame.score() == 49);
        }

        [TestMethod]
        public void ThreeFramesInLastRoll()
        {                           
            _myGame.roll(1,1); 
            _myGame.roll(1,1); 
            _myGame.roll(1,1);
            _myGame.roll(1,1);
            _myGame.roll(1,1);
            _myGame.roll(1,1);
            _myGame.roll(1,1);
            _myGame.roll(1,1);
            _myGame.roll(1,1);
            _myGame.roll(10);
            _myGame.roll(3,4);
            Assert.IsTrue(_myGame.score() == 35);
        }

        [TestMethod]
        public void StrikesInLastRoll()
        {                           
            _myGame.roll(1,1); 
            _myGame.roll(1,1); 
            _myGame.roll(1,1);
            _myGame.roll(1,1);
            _myGame.roll(1,1);
            _myGame.roll(1,1);
            _myGame.roll(1,1);
            _myGame.roll(1,1);
            _myGame.roll(1,1);
            _myGame.roll(10);
            _myGame.roll(10);
            _myGame.roll(3,4);
            Assert.IsTrue(_myGame.score() == 41);
        }

        [TestMethod]
        public void ThePerfectMatch()
        {                           
            _myGame.roll(10); _myGame.roll(10); 
            _myGame.roll(10); _myGame.roll(10); 
            _myGame.roll(10); _myGame.roll(10);
            _myGame.roll(10); _myGame.roll(10);
            _myGame.roll(10); _myGame.roll(10);
            _myGame.roll(10); _myGame.roll(10);
            Assert.IsTrue(_myGame.score() == 30);
        }

    }
}
