using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseSentenceLib;

namespace ReverseSentence
{
    [TestClass]
    public class ReverseSentenceTest
    {

        [TestMethod]
        public void testBigSen()
        {
            String test_sen = "David Frisby Test";
            String test_expected = "Test Frisby David";
            String ressult = ReverseSentenceLib.ReverseSentence.reverseSentence(test_sen);
            Console.Write(ressult);
            Assert.AreEqual(test_expected, ressult);
        }

        [TestMethod]
        public void testSmallSen()
        {
            String test_sen = "David Test";
            String test_expected = "Test David";
            String ressult = ReverseSentenceLib.ReverseSentence.reverseSentence(test_sen);
            Console.Write(ressult);
            Assert.AreEqual(test_expected, ressult);
        }

        [TestMethod]
        public void testOneLetterSen()
        {
            String test_sen = "D T";
            String test_expected = "T D";
            String ressult = ReverseSentenceLib.ReverseSentence.reverseSentence(test_sen);
            Console.Write(ressult);
            Assert.AreEqual(test_expected, ressult);
        }

        [TestMethod]
        public void testOneLetter()
        {
            String test_sen = "D";
            String test_expected = "D";
            String ressult = ReverseSentenceLib.ReverseSentence.reverseSentence(test_sen);
            Console.Write(ressult);
            Assert.AreEqual(test_expected, ressult);
        }

        [TestMethod]
        public void testNull()
        {
            String test_sen = null;
            String test_expected = null;
            String ressult = ReverseSentenceLib.ReverseSentence.reverseSentence(test_sen);
            Assert.AreEqual(test_expected, ressult);
        }
    }
}
