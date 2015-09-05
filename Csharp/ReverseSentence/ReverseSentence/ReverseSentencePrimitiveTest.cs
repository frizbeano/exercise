using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseSentence
{
    [TestClass]
    public class ReverseSentencePrimitiveTest
    {

        [TestMethod]
        public void testBigSen()
        {
            char[] test_sen = { 'D', 'a', 'v', 'i', 'd', ' ', 'F', 'r', 'i', 's', 'b', 'y', ' ', 'T', 'e', 's', 't', ' ',
                'G', 'o', 'o', 'd' };
            char[] test_expected = { 'G', 'o', 'o', 'd', ' ', 'T', 'e', 's', 't', ' ', 'F', 'r', 'i', 's', 'b', 'y', ' ',
                'D', 'a', 'v', 'i', 'd' };
            char[] ressult = ReverseSentenceLib.ReverseSentence.reverseSentencePrimitive(test_sen);
            Console.Write(ressult);

            CollectionAssert.AreEqual(test_expected, ressult);
        }

        [TestMethod]
        public void testSmallSen()
        {
            char[] test_sen = { 'D', 'a', 'v', 'i', 'd', ' ', 'T', 'e', 's', 't' };
            char[] test_expected = { 'T', 'e', 's', 't', ' ', 'D', 'a', 'v', 'i', 'd' };
            char[] ressult = ReverseSentenceLib.ReverseSentence.reverseSentencePrimitive(test_sen);
            Console.Write(ressult);
            CollectionAssert.AreEqual(test_expected, ressult);
        }

        [TestMethod]
        public void testOneLetterSen()
        {
            char[] test_sen = { 'D', ' ', 'T' };
            char[] test_expected = { 'T', ' ', 'D' };
            char[] ressult = ReverseSentenceLib.ReverseSentence.reverseSentencePrimitive(test_sen);
            Console.Write(ressult);
            CollectionAssert.AreEqual(test_expected, ressult);
        }

        [TestMethod]
        public void testOneLetter()
        {
            char[] test_sen = { 'D' };
            char[] test_expected = { 'D' };
            char[] ressult = ReverseSentenceLib.ReverseSentence.reverseSentencePrimitive(test_sen);
            Console.Write(ressult);
            CollectionAssert.AreEqual(test_expected, ressult);
        }

        [TestMethod]
        public void testNull()
        {
            char[] test_sen = null;
            char[] test_expected = null;
            char[] ressult = ReverseSentenceLib.ReverseSentence.reverseSentencePrimitive(test_sen);
            CollectionAssert.AreEqual(test_expected, ressult);
        }
    }
}
