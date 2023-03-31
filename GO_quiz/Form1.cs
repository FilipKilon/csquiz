using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GO_quiz
{
    public partial class Form1 : Form
    {
        // quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                // work out the percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                "Quiz Ended!" + Environment.NewLine +
                "You have answered " + score + " questions correctly." + Environment.NewLine +
                "Your total percentage is " + percentage + "%" + Environment.NewLine +
                "Click OK to play again"
                );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.cache;
                    lblQuestion.Text = "Jaka to mapa:";
                    button1.Text = "CACHE";
                    button2.Text = "Polski";
                    button3.Text = "Œwaita";
                    button4.Text = "DUST";
                    correctAnswer = 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.overpass;
                    lblQuestion.Text = "Jaka to mapa:";
                    button1.Text = "GOOGLE";
                    button2.Text = "OVERPASS";
                    button3.Text = "MIRAGE";
                    button4.Text = "Myœli";
                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.mirage;
                    lblQuestion.Text = "Jaka to mapa:";
                    button1.Text = "Europy";
                    button2.Text = "Przemyœla";
                    button3.Text = "Niemiec";
                    button4.Text = "MIRAGE";
                    correctAnswer = 4;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.nuke;
                    lblQuestion.Text = "Jaka to mapa:";
                    button1.Text = "MIRAGE";
                    button2.Text = "DUST";
                    button3.Text = "NUKE";
                    button4.Text = "CACHE";
                    correctAnswer = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.dust2;
                    lblQuestion.Text = "Jaka to mapa:";
                    button1.Text = "DUST2";
                    button2.Text = "DOM";
                    button3.Text = "SHORT DUST";
                    button4.Text = "Rosji";
                    correctAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.train;
                    lblQuestion.Text = "Jaka to mapa:";
                    button1.Text = "Afryki";
                    button2.Text = "Ameryki";
                    button3.Text = "TRAIN";
                    button4.Text = "Azji";
                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.inferno;
                    lblQuestion.Text = "Jaka to mapa:";
                    button1.Text = "Or³ów";
                    button2.Text = "Krównik";
                    button3.Text = "INFERNO";
                    button4.Text = "Ostrowa";
                    correctAnswer = 3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.cobblestone;
                    lblQuestion.Text = "Jaka to mapa:";
                    button1.Text = "Papierowa";
                    button2.Text = "Topograficzna";
                    button3.Text = "Kamienia";
                    button4.Text = "COBBLESTONE";
                    correctAnswer = 4;
                    break;
            }
        }
    }
}