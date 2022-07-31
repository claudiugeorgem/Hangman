using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace HangmanGame
{
    public partial class GameWindow : Form
    {
        private Bitmap[] hangImages = { HangmanGame.Properties.Resources.Default,
                                        HangmanGame.Properties.Resources.Mistake1, HangmanGame.Properties.Resources.Mistake2,
                                        HangmanGame.Properties.Resources.Mistake3, HangmanGame.Properties.Resources.Mistake4,
                                        HangmanGame.Properties.Resources.Mistake5, HangmanGame.Properties.Resources.Mistake6};

        private int wrongGuesses = 0;
        private string current = "";
        private string currentAux = "";
        private string[] words;
        private string[] hint;
        int idx;

        public GameWindow()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            loadWords();
            setupWordChoice();
            label6.Text = LogInWindow.SetValueForText1;

            using (IDbConnection db = new SqlConnection(Connection.ConString("HangMan")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                Users obj = db.Query<Users>($"SELECT * FROM Users where Username = '{label6.Text}'", commandType: CommandType.Text).SingleOrDefault();

                label3.Text = obj.Games.ToString();
            }

            label7.Visible = false;
            label8.Visible = false;

        }

        private void loadWords()
        {
            string[] readText = File.ReadAllLines("HangManWords.csv");
            char[] delimiterChar = { ',' };
            words = new string[readText.Length];
            hint = new string[readText.Length];
            int index = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(delimiterChar);
                words[index] = line[1];
                hint[index] = line[2];
                index++;
            }

        }

        private void setupWordChoice()
        {
            wrongGuesses = 0;
            pictureBox1.Image = hangImages[wrongGuesses];
            int guessIndex = (new Random()).Next(words.Length);
            current = words[guessIndex];
            idx = guessIndex;

            currentAux = "";
            for (int i = 0; i < current.Length; i++)
            {
                currentAux += "_";
            }
            displayCurrent();
        }

        private void displayCurrent()
        {
            label4.Text = "";
            for (int i = 0; i < currentAux.Length; i++)
            {
                label4.Text += currentAux.Substring(i, 1);
                label4.Text += " ";
            }
        }

        private void guess_Click(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;

            if(clickedbutton!=null)
            {
                clickedbutton.Enabled = false;
                if (current.Contains(clickedbutton.Text))
                {
                    char[] temp = currentAux.ToCharArray();
                    char[] find = current.ToCharArray();
                    char letter = clickedbutton.Text.ElementAt(0);

                    for (int i = 0; i < find.Length; i++)
                    {
                        if (find[i] == letter)
                        {
                            temp[i] = letter;
                        }
                    }
                    currentAux = new string(temp);
                    displayCurrent();
                }
                else
                {
                    wrongGuesses++;
                }

            }

            if (wrongGuesses < 6)
            {
                pictureBox1.Image = hangImages[wrongGuesses];

            }
            else
            {
                pictureBox1.Image = hangImages[wrongGuesses];
                DialogResult continuare = MessageBox.Show(this, "You lost the game. Do you wish to play again?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (continuare == DialogResult.Yes)
                {
                    this.Hide();
                    GameWindow f = new GameWindow();
                    f.ShowDialog();
                }
                if (continuare == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            if (currentAux.Equals(current))
            {
                DBOperations obActualizare = new DBOperations();
                int aux = int.Parse(label3.Text);
                obActualizare.UpdateGames(label6.Text, LogInWindow.SetValueForText2, aux + 1);

                DialogResult continuare = MessageBox.Show(this, "You win the game. Do you wish to play again?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (continuare == DialogResult.Yes)
                {
                    this.Hide();
                    GameWindow f = new GameWindow();
                    f.ShowDialog();
                }
                if (continuare == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label8.Visible = true;
            label8.Text = hint[idx];
        }
    }
}