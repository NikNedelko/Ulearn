using System;
using System.Collections.Generic;
using System.Linq;

namespace Passwords
{
    public class CaseAlternatorTask
    {
        //Тесты будут вызывать этот метод
        public static List<string> AlternateCharCases(string lowercaseWord)
        {
            var result = new List<string>();

            var pogran = (lowercaseWord.Replace(" ","")).ToCharArray();
            int counter = 0;
            foreach (var item in pogran)
            {
                if (char.IsNumber(item))
                {
                    counter++;
                }
            }
            if (counter==pogran.Length)
            {
                result.Add(lowercaseWord);
                return result;
            }
            AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
            return result;
        }
        
        static void AlternateCharCases(char[] word, int startIndex, List<string> result)
        {
            
            var subWord = word.ToArray();
            if (startIndex == word.Length)
            {
                result.Add(new string(word));
                return;
            }
            var lower = char.ToLower(word[startIndex]);
            var upper = char.ToUpper(word[startIndex]);
            word[startIndex] = lower;
            AlternateCharCases(word, startIndex + 1, result);
            if (lower != upper)
            {
                word[startIndex] = upper;
                AlternateCharCases(word, startIndex + 1, result);
            }
        }
    }
}