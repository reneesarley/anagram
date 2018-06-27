using System;
using System.Collections.Generic;

namespace Anagrams
{
    public class Word
    {
        // add properties of Word class
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
        // create method for list of verified anagrams
    }
}
