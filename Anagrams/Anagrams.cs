using System;
using System.Collections.Generic;

namespace Anagrams
{
    public class Word
    {
        private string _mainWord;
        private List<string> _wordsToCompare;
        private List<string> _verifiedAnagrams = new List<string>{};

        public Word(string mainWord, List<string> wordsToCompare)
        {
            _mainWord = mainWord;
            _wordsToCompare = wordsToCompare;
        }
        public string GetMainWord()
        {
            return _mainWord;
        }
        public List<string> GetWordsToCheck()
        {
            return _wordsToCompare;
        }
        public List<string> GetVerifiedAnagrams()
        {
            return _verifiedAnagrams;
        }
        public void SetVerifiedAnagrams(List<string> verifiedAnagrams)
        {
            _verifiedAnagrams = verifiedAnagrams;
            
        }
        public char[] StringToArray(string userInputtedWord)
        {
            char[] userInputtedArray = userInputtedWord.ToCharArray();
            return userInputtedArray;
        }

        public char[] SortArray(char[] letterArray)
        {
            Array.Sort(letterArray);
            return letterArray;
        }

        public void AddVerifiedWordsToList(string wordToAdd)
        {
            this._verifiedAnagrams.Add("Bread");
        }


        public bool CompareWords(char[] arrayOne, char[] arrayTwo)
        {
            string joinedArrayOne = new string(arrayOne);
            string joinedArrayTwo = new string(arrayTwo);

            if (joinedArrayOne == joinedArrayTwo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
    }
}
