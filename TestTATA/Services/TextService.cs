using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTATA.Interfaces;

namespace TestTATA.Services
{
    public class TextService : ITextService
    {
        public int CountWordsFromText(string text, string keyWord)
        {
            var delimiters = " ,.".ToCharArray();
            string[] allWords = text.Split(' ', ',', '.');
            int count = 0;
            foreach (var word in allWords)
            {
                if (word.ToLower() == keyWord.ToLower())
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
