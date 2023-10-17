using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Ahorcado.Controllers
{
    internal class Game
    {

        int chances = 12;

        public int GetChances() { return chances; }

        public List<int> CheckUserAnswer(string wordToGuess, char userChar)
        {
            int index = wordToGuess.Length, i = 0;
            List<int> charsGuessedIndex = new List<int>();

            while (i < index)
            {
                if (userChar.Equals(wordToGuess[i]))
                    charsGuessedIndex.Add(i);
                i++;
            }
            return charsGuessedIndex;
        }



        public char[] GetWordToGuessBlankString(string wordToGuess)
        {
            char[] wordBlank = new char[wordToGuess.Length];

            for (int i = 0; i < wordToGuess.Length; i++)
                wordBlank[i] = '*';

            return wordBlank;
        }

        public char[] SetWordToGuessNonBlank(string wordToGuess, char[] wordBlank, List<int> charsGuessedIndex)
        {
            if (charsGuessedIndex.Count > 0)
            {
                foreach (var item in charsGuessedIndex)
                {
                    wordBlank[item] = wordToGuess[item];
                }
            }

            return wordBlank;
        }

        public bool CheckIfPlayerWon(char[] wordBlank, string wordToGuess)
        {
            string word = new string(wordBlank);

            return word.Equals(wordToGuess);

        }

    }
}
