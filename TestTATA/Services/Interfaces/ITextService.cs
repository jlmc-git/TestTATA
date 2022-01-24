using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTATA.Interfaces
{
    public interface ITextService
    {
        int CountWordsFromText(string text, string word);
    }
}
