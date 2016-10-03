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

namespace pyluck
{
    public partial class QAForm : Form
    {
        private string userAns = "";
        private string correctAns = "";
        private int correctAnswer = 0;
        private const int maxquestions = 80;
        private int numOfQuestions;
        private static int count = 1;
        private static int index = 0;
        //ask a player 3 questions,no more no less 
        private const int questionsToAsk = 3;
        private string file = "..\\..\\luck.txt";
        private static Player[] player = new Player[2];
       // private static Player player1 = new Player();
        //private static Player player2 = new Player();
        private static QA[] qaStructure = new QA[maxquestions];

        public QAForm()
        {
            InitializeComponent();
            SubmitButton.Enabled = false;
            AnswerBox.ReadOnly = true;
            numOfQuestions = readQuestion(file); 
            shuffle();
        }

        private int readQuestion(string file)
        {
            StreamReader streamReader;
            streamReader = new StreamReader(file);
            int count;
            for(count = 0; !streamReader.EndOfStream && count < maxquestions; ++count)
            {
                qaStructure[count] = new QA();
                qaStructure[count].Q = streamReader.ReadLine();
                qaStructure[count].A = streamReader.ReadLine();
            }
            return count;
        }

        public void start()
        {
            QuestionBox.Text = "Press 'start' button to begin.";
            startButton.Enabled = true;
            SubmitButton.Enabled = false;
            nextButton.Enabled = false;
            correctAnswer = 0;
            AnswerBox.Clear();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            AnswerBox.ReadOnly = false;
            AnswerBox.Clear();
            PlayerLabel.Text = "Player1:";
            ask();
        }

        private void ask()
        {
            
                QuestionBox.Text = qaStructure[index].Q;
                AnswerBox.ReadOnly = false;
                nextButton.Enabled = false;
                SubmitButton.Enabled = true;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
            userAns = AnswerBox.Text.ToLower();
            correctAns = qaStructure[index].A.ToLower();

            for (int i = 0; i < 3; i++)
            {
                PlayerLabel.Text = "Player" + i  + ":";
                if (userAns == correctAns)
                {
                    resultLabel.Text = "Correct, Plus 1 spin";
                    player[i].addSpins(1);
                    correctAnswer++;
                }
                else
                    resultLabel.Text = "Incorrect";

                if (count == questionsToAsk)
                {
                    nextButton.Text = "Done";
                }

                index = (index + 1) % numOfQuestions;
                nextButton.Enabled = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            AnswerBox.Clear();
            resultLabel.Text = "";

            if(nextButton.Text != "Done")
            {
                index = (index + 1) % numOfQuestions;
                count++;
                if (count == maxquestions + 1)
                {
                    nextButton.Text = "Done";
                    SubmitButton.Enabled = false;
                }
                else
                    ask();
            }
            else
            {
                this.Close();
            }
        }

        private void shuffle()
        {
            Random rnd = new Random();
            int randindex;
            randindex = rnd.Next();
        }
    }
}