using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado.Models
{
    internal static class ListOfWords
    {
        private static List<string> words = new List<string>()
        {
            "object",
            "class",
            "visualstudio",
            "cleancode",
            "microsoft",
            "coffee",
            "function",
            "form"
        };

        public static string GetWord(int i) { return words[i]; }

        public static int CountWords() { return words.Count; }

    }
}
