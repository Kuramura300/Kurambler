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

        private void readFile()
        {
            words.Clear();
            lstWords.Items.Clear();

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
            }
        }

        private void BtnUnscramble_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            char[] scrambledText = txtboxScrambled.Text.ToCharArray();

            foreach (string word in words)
            {
                char[] splitWord = word.ToCharArray();

                int matchCount = 0;
                List<char> matchedLetters = new List<char>();

                foreach (char wordLetter in splitWord)
                {
                    foreach (char scrambledLetter in scrambledText)
                    {
                        if (Char.ToLower(wordLetter) == Char.ToLower(scrambledLetter))
                        {
                            matchCount++;
                            matchedLetters.Add(wordLetter);
                            break;
                        }
                    }
                }

                if (matchCount == scrambledText.Length)
                {
                    if (word.Length == scrambledText.Length)
                    {
                        lstResults.Items.Add(word);
                    }
                }
            }
        }
    }
}
