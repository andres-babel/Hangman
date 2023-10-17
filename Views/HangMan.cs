using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ahorcado.Controllers;
using Ahorcado.Models;

namespace Ahorcado
{
    public partial class HangMan : Form
    {
        Game game;
        string wordToGuess;
        char[] wordBlank;
        List<int> indexes;
        int chances;
        public HangMan()
        {
            InitializeComponent();
            game = new Game();
            wordToGuess = string.Empty;
            wordBlank = new char[0];
            indexes = new List<int>();
            chances = game.GetChances();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            chances--;
            
            Player.playerTries += 1;
            string letterChosen = textBox3.Text.ToLower();
            char letter = letterChosen[0];
            indexes = game.CheckUserAnswer(wordToGuess, letter);
            wordBlank = game.SetWordToGuessNonBlank(wordToGuess.ToLower(), wordBlank, indexes);

            textBox3.Text = "";
            textBox1.Text = chances.ToString();
            textBox2.Text = new string(wordBlank);

            Player.won = game.CheckIfPlayerWon(wordBlank, wordToGuess);

            if (chances == 0 || Player.won)
            {
                Resultado resultado = new Resultado();
                resultado.Show();
            }

        }

        private void HangMan_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int word = rnd.Next(0, ListOfWords.CountWords());

            textBox1.Text = chances.ToString();

            wordToGuess = ListOfWords.GetWord(word);
            wordBlank = new char[wordToGuess.Length];
            wordBlank = game.GetWordToGuessBlankString(wordToGuess.ToLower());
            textBox2.Text = new string(wordBlank);
        }
    }
}
