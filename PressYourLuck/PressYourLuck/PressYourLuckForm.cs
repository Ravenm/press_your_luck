using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using pyluck;

namespace PressYourLuck
{
    public partial class PressYourLuckForm : Form
    {
        //holds the game tiles
        private GameTile[] tileArray;

        private string _userAns = "";
        private string _correctAns = "";
        private int _numPlayer = 2;
        private int correctAnswer = 0;
        private const int Maxquestions = 80;
        private readonly int _numOfQuestions;
        private int _currentPlayer = 0;
        private static int _count = 1;
        private static int _index;
        private string _file = "..\\..\\luck.txt";
        private static readonly Player[] Player = new Player[2];
        // private static Player player1 = new Player();
        //private static Player player2 = new Player();
        private static readonly QA[] QaStructure = new QA[Maxquestions];
        private int _selectedTile;

        //init set instructions create tiles disable some btns
        public PressYourLuckForm()
        {
            InitializeComponent();
            tileArray = new GameTile[8];
            SubmitBtn.Enabled = false;
            NextBtn.Enabled = false;
            EnableBuzzer();
            DisableSpinner();
            AnswerBox.ReadOnly = true;
            _numOfQuestions = ReadQuestion(_file);
            Instruction.Text = @"Press Start to begin";
            for (var i = 0; i < _numPlayer; i++)
            {
                Player[i] = new Player();
            }
            QuestionBox.Text = @"Press 'start' button to begin.";
            //Shuffle();
        }

        /// <summary>
        /// sets the instructions, starts the game, updates score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameStart_Click(object sender, EventArgs e)
        {
            CreateTiles();
            correctAnswer = 0;
            UpdateScore();
            AnswerBox.Clear();
            AnswerBox.ReadOnly = true;
            NextBtn_Click(sender, e);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Use the Buzz In button to attempt the question");
            stringBuilder.AppendLine("Use the Submit button to submit your answer");
            stringBuilder.AppendLine("Use the Next button to start the next question");
            stringBuilder.AppendLine("After successfully answering a question use the spin button to attempt to get a prize");
            stringBuilder.AppendLine("Use the stop button to select a tile");
            stringBuilder.AppendLine("Your score is listed in the top right");

            Instruction.Text = stringBuilder.ToString();

        }

        /// <summary>
        /// creates the tiles around a center point and addes them to an array to access
        /// </summary>
        private void CreateTiles()
        {
            // set on offset to skip center square only needed here for xy location
            var offset = 0;
            //loop 3 rows 3 colomns
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    //calculate the actual array index 
                    var index = (i * 3) + j;
                    if (index == 4)
                    {
                        offset = 1;
                        continue;
                    }
                    // create the new picturebox at index location ie tileArray[2]
                    tileArray[index - offset] = new GameTile(new Point(j * 150 + 200, i * 150 + 50));
                    //add picturebox to form
                    this.Controls.Add(tileArray[index - offset]);
                }
            }
        }

        /// <summary>
        /// disable the spin buttons
        /// </summary>
        private void DisableSpinner()
        {
            SpinBtnPlayer1.Enabled = false;
            StopBtnPlayer1.Enabled = false;
            SpinBtnPlayer2.Enabled = false;
            StopBtnPlayer2.Enabled = false;
        }

        /// <summary>
        /// read in the questions from file
        /// </summary>
        /// <param name="file"></param>
        /// <returns>the number of questions read in</returns>
        private static int ReadQuestion(string file)
        {
            var streamReader = new StreamReader(file);
            var count=0;
            while (!streamReader.EndOfStream)
            {
                QaStructure[count] = new QA
                {
                    Q = streamReader.ReadLine(),
                    A = streamReader.ReadLine()
                };
                count++;
            }
            return count;
        }

        /// <summary>
        /// sets current player and calls buzzIn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuzzPlayer1_Click(object sender, EventArgs e)
        {
            _currentPlayer = 0;
            BuzzIn();
        }

        /// <summary>
        /// 'spins' the tiles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpinBtnPlayer1_Click(object sender, EventArgs e)
        {
            StopBtnPlayer1.Enabled = true;
            ResultLabel.Text = "";
            var rand = new Random();
            _selectedTile = rand.Next(0,8);

        }

        /// <summary>
        /// simulated stop for the spinner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopBtnPlayer1_Click(object sender, EventArgs e)
        {
            StopSpin();
        }

        /// <summary>
        /// Buzzes a player in for the question, disables the other buzzer and sets a label
        /// to indicate who is up
        /// </summary>
        private void BuzzIn()
        {
            if (_currentPlayer == 0)
            {
                BuzzPlayer2.Enabled = false;
            }
            else
            {
                BuzzPlayer1.Enabled = false;
            }
            SubmitBtn.Enabled = true;
            AnswerBox.ReadOnly = false;
            var player = _currentPlayer + 1;
            PlayerLabel.Text = @"Player: " + player;
        }

        /// <summary>
        /// simulates stopping the spinner gives a popout of what you won
        /// </summary>
        private void StopSpin()
        {
            SpinBtnPlayer1.Enabled = false;
            SpinBtnPlayer2.Enabled = false;

            if (tileArray[_selectedTile].IsWhammy())
            {
                System.Windows.Forms.MessageBox.Show(@"OH NO WHAMMY!!");
                Player[_currentPlayer].AddWhammy();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(@"WoW you won " + tileArray[_selectedTile].GetPrizeText());
                AddPrize();
            }

            for (var i = 0; i < 8; i++)
            {
                this.Controls.Remove(tileArray[i]);
            }
            // set on offset to skip center square only needed here for xy location
            var offset = 0;
            //loop 3 rows 3 colomns
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    //calculate the actual array index 
                    var index = (i * 3) + j;
                    if (index == 4)
                    {
                        offset = 1;
                        continue;
                    }
                    // create the new picturebox at index location ie tileArray[2]
                    tileArray[index - offset] = new GameTile(new Point(j * 150 + 200, i * 150 + 50));
                    //add picturebox to form
                    this.Controls.Add(tileArray[index - offset]);
                }
            }
            StopBtnPlayer1.Enabled = false;
            StopBtnPlayer2.Enabled = false;

        }

        /// <summary>
        /// add the prize value to the current player if the won something
        /// </summary>
        private void AddPrize()
        {
            Player[_currentPlayer].AddPrize(tileArray[_selectedTile].GetValue());
        }

        /// <summary>
        /// calls buzzIn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuzzPlayer2_Click(object sender, EventArgs e)
        {
            BuzzIn();
        }

        /// <summary>
        /// spins' the tiles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpinBtnPlayer2_Click(object sender, EventArgs e)
        {
            StopBtnPlayer1.Enabled = true;
            ResultLabel.Text = "";
            var rand = new Random();
            _selectedTile = rand.Next(0, 8);
        }

        /// <summary>
        /// calls StopSpin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopBtnPlayer2_Click(object sender, EventArgs e)
        {
            StopSpin();
        }

        /// <summary>
        /// updates the score box with current player scores
        /// </summary>
        private void UpdateScore()
        {
            StringBuilder scoreText = new StringBuilder();
            scoreText.AppendLine("Player 1");
            scoreText.AppendLine("Cash Prizes: " + Player[0].GetPize());
            scoreText.AppendLine("Whammies: " + Player[0].GetWhammy());
            scoreText.AppendLine("Correct Answers: " + Player[0].GetScore());
            scoreText.AppendLine();
            scoreText.AppendLine("Player 2");
            scoreText.AppendLine("Cash Prizes: " + Player[1].GetPize());
            scoreText.AppendLine("Whammies: " + Player[1].GetWhammy());
            scoreText.AppendLine("Correct Answers: " + Player[1].GetScore());
            ScoreBox.Text = scoreText.ToString();
        }

        /// <summary>
        /// submits an answer to a question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            BuzzPlayer2.Enabled = false;
            BuzzPlayer1.Enabled = false;

            QuestionBox.Text = "";

            SubmitBtn.Enabled = false;

            _userAns = AnswerBox.Text.ToLower();
            _correctAns = QaStructure[_index].A.ToLower();

            //if correct endable the spinner add points
            if (_userAns == _correctAns)
            {
                ResultLabel.Text = @"Correct, Plus 1 spin";
                Player[_currentPlayer].AddScore();
                EnableSpin();
            }
            //else show what was correct
            else
            {
                ResultLabel.Text = @"Incorrect: " + _correctAns;
            }
            //too many questions get out
            if (_count >= _numOfQuestions)
            {
                NextBtn.Text = @"Done";
            }

            //??
            _index = (_index + 1)%_numOfQuestions;
            NextBtn.Enabled = true;
            UpdateScore();

            AnswerBox.Clear();
            AnswerBox.Text = "";
            AnswerBox.ReadOnly = true;
        }

        /// <summary>
        /// enables the spin buttons
        /// </summary>
        private void EnableSpin()
        {
            if (_currentPlayer == 0)
            {
                SpinBtnPlayer1.Enabled = true;
            }
            else
            {
                SpinBtnPlayer2.Enabled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ppulls a random question and displays it
        /// </summary>
        private void Ask()
        {
            var rand = new Random();
            QuestionBox.Text = QaStructure[rand.Next(0,_numOfQuestions)].Q;
            AnswerBox.ReadOnly = false;
            NextBtn.Enabled = false;
        }

        /// <summary>
        /// enables the buzz in buttons
        /// </summary>
        /// <param name="pass"></param>
        public void EnableBuzzer(bool pass = false)
        {
            BuzzPlayer2.Enabled = pass;
            BuzzPlayer1.Enabled = pass;
        }

        /// <summary>
        /// calls ask to set up the next question does some checking to test if a player has won
        /// or we have gone over the max questions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextBtn_Click(object sender, EventArgs e)
        {
            _count++;
            BuzzPlayer2.Enabled = true;
            BuzzPlayer1.Enabled = true;

            AnswerBox.Clear();
            ResultLabel.Text = "";

            EnableBuzzer(true);

            if (NextBtn.Text != @"Done")
            {
                if (_count > Maxquestions || Player[0].GetScore() > 10 || Player[1].GetScore() > 10)
                {
                    NextBtn.Text = @"Done";
                    NextBtn.Enabled = false;
                    System.Windows.Forms.MessageBox.Show(Player[0].GetScore() > Player[1].GetScore()
                        ? @"WoW Plaery 1 WON!!"
                        : @"WoW Player 2 WON!!");
                }
                else
                {
                    Ask();
                    UpdateScore();
                }
            }
            else
            {
                this.Close();
            }
        }

    }
}
