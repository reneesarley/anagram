using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams;

namespace Anagrams.Test
{
    [TestClass]
    public class WordTest
    {
        [TestMethod]
        public void StringToArray_StringBreaksIntoArray_CharArray()
        {
            Word newWord = new Word();
            char[] letterArray = new char[5];
            letterArray = newWord.StringToArray("bread");
            char[] testArray = new char[] { 'b', 'r', 'e', 'a', 'd' };

            CollectionAssert.AreEqual(letterArray, testArray);
        }
        [TestMethod]
        public void SortArray_StringSortedAlphabetically_CharArray()
        {
            Word newWord = new Word();
            char[] testArray = new char[] {'a', 'b', 'd', 'e', 'r'};
            char[] letterArray = new char[] { 'b', 'r', 'e', 'a', 'd' };
            char[] finalArray = new char[5];
            finalArray = newWord.SortArray(letterArray);
            CollectionAssert.AreEqual(testArray, finalArray);
        }
        [TestMethod]
        public void CompareWords_CompareIfWordsAreEqual_True()
        {
            Word newWord = new Word();
            char[] arrayOne = new char[] { 'b', 'r', 'e', 'a', 'd' };
            char[] arrayTwo = new char[] { 'b', 'r', 'e', 'a', 'd' };
            bool compareArrays = newWord.CompareWords(arrayOne, arrayTwo);
            Assert.AreEqual(compareArrays, true);
        }
    }
}
