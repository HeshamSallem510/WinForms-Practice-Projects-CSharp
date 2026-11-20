using Project3QuizzApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static Project3QuizzApp.Form2;

namespace Project3QuizzApp
{

    public partial class Form2 : Form
    {
        clsQuestions Questions = new clsQuestions();
        public string Difficulty;
        private short SecondsLeft;


        public enum enWinner
        {
            Player,
            Computer,
            GameInProgress,
            Draw
        }

        public Form2()
        {
            InitializeComponent();
            this.Shown += (s, e) => CheckSecondsLeft();
            GenerateQuestion();
            
        }

        private void CheckSecondsLeft()
        {
            if (Difficulty == "Beginner")
            {
                SecondsLeft = 360;
            }
            else if (Difficulty == "Easy")
            {
                SecondsLeft = 300;
            }
            else if (Difficulty == "Medium")
            {
                SecondsLeft = 240;
            }
            else
            {
                SecondsLeft = 180;
            }
        }

        private void CheckTimeLeft()
        {
            if (SecondsLeft == 0)
            {
                EndGame();
                return;
            }
            if (SecondsLeft % 60 < 10)
            {
                lblminutesleft.Text = $"0{SecondsLeft / 60}:0{SecondsLeft % 60}";
                return;
            }

            lblminutesleft.Text = $"0{SecondsLeft / 60}:{SecondsLeft % 60}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SecondsLeft--;
            CheckTimeLeft();
        }

        private bool CheckWinner()
        {
            if (Questions.CorrectAnswers > 5 && SecondsLeft > 0)
            {
                Questions.Winner = enWinner.Player;
            }
            else if (Questions.CorrectAnswers < 5 && SecondsLeft > 0)
            {
                Questions.Winner = enWinner.Computer;
            }
            else
            {
                Questions.Winner = enWinner.Draw;
            }
            return Questions.Winner == enWinner.Player;
        }

        private void EndGame()
        {
            timer1.Stop();
            btnsubmit.Enabled = false;
            btnPlayAgain.Enabled = true;
            panel1.Enabled = false;
            if (CheckWinner())
            {
                lblQuestion.Text = $"You won!! Kudos! Your score is:{Questions.CorrectAnswers}";
                pictureBox1.Image = imageList1.Images[9];
            }
            else
            {
                lblQuestion.Text = $"No worries. You can try again. Your score is:{Questions.CorrectAnswers} ";
                pictureBox1.Image = imageList1.Images[8];
            }
        }

        private void SwapQuestions(byte Number)
        {
            for (byte i = 0; i <= 4; i++)
            {
                string temp = Questions.QuestionsArray[Number, i];
                Questions.QuestionsArray[Number, i] = Questions.QuestionsArray[Questions.QuestionsLeft, i];
                Questions.QuestionsArray[Questions.QuestionsLeft, i] = temp;
            }
        }

        private void RepresentQuestion()
        {
            lblQuestion.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 0];
        }

        private void RepresentAnswers()
        {
            Random rnd = new Random();
            byte NumberPattern = Convert.ToByte(rnd.Next(1, 4));
            if (NumberPattern == 1)
            {
                rbAnswer1.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 1];
                rbAnswer2.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 2];
                rbAnswer3.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 3];
                rbAnswer4.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 4];
            }
            if (NumberPattern == 2)
            {
                rbAnswer4.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 1];
                rbAnswer3.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 2];
                rbAnswer2.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 3];
                rbAnswer1.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 4];
            }
            if (NumberPattern == 3)
            {
                rbAnswer3.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 1];
                rbAnswer2.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 2];
                rbAnswer4.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 3];
                rbAnswer1.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 4];
            }
            else
            {
                rbAnswer2.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 1];
                rbAnswer4.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 2];
                rbAnswer3.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 3];
                rbAnswer1.Text = Questions.QuestionsArray[Questions.QuestionsLeft, 4];
            }


        }

        private void EditProgressBar()
        {
            progressBar1.Value++;
            lblprogressbar.Text = $"Current Question: {progressBar1.Value}";
        }

        private void GenerateQuestion()
        {

            if (Questions.QuestionsLeft >= 1)
            {
                Random rnd = new Random();
                byte Number = Convert.ToByte(rnd.Next(0, Questions.QuestionsLeft));
                SwapQuestions(Number);
                RepresentQuestion();
                RepresentAnswers();
                byte PicNumber = Convert.ToByte(rnd.Next(0, 6));
                pictureBox1.Image = imageList1.Images[PicNumber];
                EditProgressBar();
            }
            else if (Questions.QuestionsLeft == 0)
            {
                RepresentQuestion();
                RepresentAnswers();
                Random rnd = new Random();
                byte PicNumber = Convert.ToByte(rnd.Next(0, 6));
                pictureBox1.Image = imageList1.Images[PicNumber];
                EditProgressBar();
            }
            else
            {
                EndGame();
            }
        }

        private void rbAnswerChosen(object sender, EventArgs e)
        {
            RadioButton TheButton = ButtonChosen();
            if (TheButton == null)
                btnsubmit.Enabled = false;
            else btnsubmit.Enabled = true;
        }

        private RadioButton ButtonChosen()
        {
            if (rbAnswer1.Checked == true)
                return rbAnswer1;
            if (rbAnswer2.Checked == true)
                return rbAnswer2;
            if (rbAnswer3.Checked == true)
                return rbAnswer3;
            if (rbAnswer4.Checked == true)
                return rbAnswer4;

            return null;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            RadioButton TheButton = ButtonChosen();

            if (TheButton.Text == Questions.QuestionsArray[Questions.QuestionsLeft, 1])
            {
                Questions.CorrectAnswers++;
                Questions.CurrentQuestion++;
            }
            else
            {
                Questions.CurrentQuestion++;
            }
            Questions.QuestionsLeft--;
            GenerateQuestion();
            btnsubmit.Enabled = false;
            TheButton.Checked = false;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Questions.CorrectAnswers = 0;
            Questions.CurrentQuestion = 1;
            Questions.QuestionsLeft = 9;
            Questions.Winner = enWinner.GameInProgress;
            panel1.Enabled = true;
            btnPlayAgain.Enabled = false;
            progressBar1.Value = 0;
            lblprogressbar.Text = $"Current Question: {progressBar1.Value}";
            timer1.Enabled = true;
            CheckSecondsLeft();
            GenerateQuestion();
            
        }


    }

    public class clsQuestions
    {
        public string[,] QuestionsArray = new string[10, 5]
{
    { "Which team won the Premier League in the 2003-04 season?", "Arsenal", "Chelsea", "Manchester United", "Liverpool" },
    { "Who was the top scorer in the 2007-08 Premier League season?", "Cristiano Ronaldo", "Fernando Torres", "Didier Drogba", "Wayne Rooney" },
    { "Which player won the PFA Player of the Year award in 2005?", "John Terry", "Thierry Henry", "Frank Lampard", "Steven Gerrard" },
    { "Which club was promoted to the Premier League for the first time in the 2007-08 season?", "Stoke City", "Reading", "Sunderland", "Birmingham City" },
    { "Which goalkeeper holds the record for the most clean sheets in a single Premier League season (2004-05)?", "Petr Čech", "Edwin van der Sar", "Jens Lehmann", "Brad Friedel" },
    { "Who scored the goal that secured Manchester United the 2008 Premier League title?", "Carlos Tevez", "Wayne Rooney", "Cristiano Ronaldo", "Ryan Giggs" },
    { "Which manager led Chelsea to their first Premier League title in 2005?", "José Mourinho", "Carlo Ancelotti", "Claudio Ranieri", "Guus Hiddink" },
    { "Which team finished second behind Manchester United in the 2006-07 Premier League season?", "Chelsea", "Arsenal", "Liverpool", "Tottenham Hotspur" },
    { "Who scored the fastest Premier League hat-trick in the 2000s, in just 4 minutes?", "Jermain Defoe", "Michael Owen", "Robbie Fowler", "Alan Shearer" },
    { "Which player won the 2008-09 Premier League Golden Boot?", "Nicolas Anelka", "Wayne Rooney", "Didier Drogba", "Fernando Torres" }
};
        public enWinner Winner;
        public byte CorrectAnswers = 0;
        public byte CurrentQuestion = 1;
        public sbyte QuestionsLeft = 9;
        // Answer is first element
    }
}
