using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string phrase)
        {
            List<char> words = phrase.ToList();

            int tally = 0;
            string reverse = "";

            if (phrase == null)
            {
                return false;
            }

            for (int i = words.Count-1; i >= 0; i--) {
                reverse += words[i].ToString();
            }

            if (reverse == phrase)
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
