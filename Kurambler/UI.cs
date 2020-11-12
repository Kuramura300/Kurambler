using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kurambler
{
    public partial class UI : Form
    {
        string fileName = "";

        List<string> words = new List<string>();

        public UI()
        {
            InitializeComponent();
        }

        //Open dialog to import file when import button clicked
        private void BtnImportFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileName = openFileDialog.FileName;

                    readFile();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: " + exception.Message);
                }
            }
        }

        //Read in imported file
        private void readFile()
        {
            words.Clear();
            lstWords.Items.Clear();
            lstToScramble.Items.Clear();

            StreamReader readFile = new StreamReader(fileName);

            string data = readFile.ReadToEnd();
            string[] splitData = data.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in splitData)
            {
                words.Add(word);
            }

            readFile.Close();

            txtWordCount.Text = "Words: " + words.Count;

            foreach (string word in words)
            {
                lstWords.Items.Add(word);
                lstToScramble.Items.Add(word);
            }
        }

        //Unscramble button clicked
        private void BtnUnscramble_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            char[] scrambledText = txtboxScrambled.Text.ToCharArray();

            foreach (string word in words)
            {
                char[] splitWord = word.ToCharArray();

                int matchCount = 0;

                bool[] scrambledMatches = new bool[splitWord.Length];

                for (int l = 0; l < scrambledMatches.Length; l++)
                {
                    scrambledMatches[l] = false;
                }

                if (word.Length == scrambledText.Length)
                {
                    for (int wL = 0; wL < splitWord.Length; wL++)
                    {
                        for (int sL = 0; sL < scrambledText.Length; sL++)
                        {
                            if (Char.ToLower(splitWord[wL]) == Char.ToLower(scrambledText[sL]))
                            {
                                if (scrambledMatches[sL] == false)
                                {
                                    matchCount++;
                                    scrambledMatches[sL] = true;
                                    break;
                                }
                            }
                        }
                    }
                }

                if (matchCount == scrambledText.Length)
                {
                    lstResults.Items.Add(word);
                }
            }
        }

        //Scrambler button clicked
        private void LstToScramble_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = lstToScramble.SelectedItem.ToString();

            char[] letters = text.ToCharArray();

            Random rng = new Random();

            int n = letters.Length;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = letters[k];
                letters[k] = letters[n];
                letters[n] = value;
            }

            text = new string(letters);

            txtBoxScramblified.Text = text;
        }
    }
}
