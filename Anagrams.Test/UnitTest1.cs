using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams;
using System.Collections.Generic;
using System;

namespace Anagrams.Test
{
    [TestClass]
    public class WordTest
    {
        [TestMethod]
        public void StringToArray_StringBreaksIntoArray_CharArray()
        {
            List<string> testList = new List<string> { "spaghetti", "tomatoes" };
            Word newWord = new Word("string", testList);
            char[] letterArray = new char[5];
            letterArray = newWord.StringToArray("bread");
            char[] testArray = new char[] { 'b', 'r', 'e', 'a', 'd' };

            CollectionAssert.AreEqual(letterArray, testArray);
        }
        [TestMethod]
        public void SortArray_StringSortedAlphabetically_CharArray()
        {
            List<string> testList = new List<string> { "spaghetti", "tomatoes" };
            Word newWord = new Word("string", testList);
            char[] testArray = new char[] { 'a', 'b', 'd', 'e', 'r' };
            char[] letterArray = new char[] { 'b', 'r', 'e', 'a', 'd' };
            char[] finalArray = new char[5];
            finalArray = newWord.SortArray(letterArray);
            CollectionAssert.AreEqual(testArray, finalArray);
        }
        [TestMethod]
        public void CompareWords_CompareIfWordsAreEqual_True()
        {
            List<string> testList = new List<string> { "spaghetti", "tomatoes" };
            Word newWord = new Word("string", testList);
            char[] arrayOne = new char[] { 'b', 'r', 'e', 'a', 'd' };
            char[] arrayTwo = new char[] { 'b', 'r', 'e', 'a', 'd' };
            bool compareArrays = newWord.CompareWords(arrayOne, arrayTwo);
            Assert.AreEqual(compareArrays, true);
        }
        [TestMethod]
        public void GetMainWord_ReturnsMainWord_String()
        {
            //Arrange
            string mainWord = "Bread";
            List<string> testList = new List<string> { "spaghetti", "tomatoes" };
            Word newWord = new Word(mainWord, testList);

            //Act
            string result = newWord.GetMainWord();

            //Assert
            Assert.AreEqual(mainWord, result);
        }
        [TestMethod]
        public void GetWordsToCheck_ReturnsWordsToCheck_List()
        {
            //Arrange
            string mainWord = "Bread";
            List<string> testList = new List<string> { "spaghetti", "tomatoes" };
            Word newWord = new Word(mainWord, testList);

            //Act
            List<string> result = newWord.GetWordsToCheck();

            //Assert
            CollectionAssert.AreEqual(testList, result);
        }
        [TestMethod]
        public void SetGetVerifiedAnagrams_ReturnVerfiedWords_List()
        {
            //Arrange
            string mainWord = "Bread";
            List<string> testList = new List<string> { "Bread" };
            Word newWord = new Word(mainWord, testList);

            //Act
            newWord.SetVerifiedAnagrams(testList);
            List<string> result = newWord.GetVerifiedAnagrams();

            //Assert
            CollectionAssert.AreEqual(testList, result);
        }
        [TestMethod]
        public void AddVerifiedWordsToList_ReturnVerifiedList_List()
        {
            //Arrange
            string mainWord = "Bread";
            List<string> testList = new List<string> { "Dog" };
            List<string> listToTestAgainstResult = new List<string> { "Bread" };
            Console.WriteLine(listToTestAgainstResult[0]);
            Word newWord = new Word(mainWord, testList);
            Console.WriteLine(newWord.GetMainWord());

            //Act
            newWord.AddVerifiedWordsToList(mainWord);
            //List<string> result = new List<string> { "Bread" };
            List<string> result = newWord.GetVerifiedAnagrams();

            //Assert
            CollectionAssert.AreEqual(listToTestAgainstResult, result);
        }
    }
}
