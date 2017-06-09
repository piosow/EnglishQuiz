using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishQuiz
{
    public partial class fQuiz : Form
    {
        private List<QuestionClass> ListOfQuestions = new List<QuestionClass>();
        private Player Player = new Player();
        private int currentQuestion = 1;
        private int maxQuestions;
        private Random rand = new Random();

        public fQuiz()
        {
            InitializeComponent();
        }

        public fQuiz(Category currentCategory,ref Player currentPlayer, int size = 10)
        {
            InitializeComponent();
            Player = currentPlayer;
            maxQuestions = size;
            
            GenerateQuiz(currentCategory, Player, size);
            SetupControls();
        }

        private void UpdatePlayerStatus()
        {
            var selection = gbAnswers.Controls.OfType<RadioButton>().FirstOrDefault(ch => ch.Checked);
            if (selection.Text.Equals(ListOfQuestions.Where(w => w.QuestionNumber == currentQuestion).Select(s => s.CorrectAnswer).First()))
            {
                Player.CorrectAnswers++;
            }
            else Player.WrongAnswers++;
            selection.Checked = false;
        }

        private void GenerateQuiz(Category curCat, Player player, int questionsAmount)
        {
            QuestionClass qc = new QuestionClass();
            qc.GenerateQuestions(questionsAmount, curCat);
            ListOfQuestions = qc.QuizQuestions;
        }

        private void fQuiz_Load(object sender, EventArgs e)
        {
            
        }

        private void SetupControls()
        {
            List<int> controlsSequence = new[] { 1, 2, 3, 4 }.OrderBy(o => rand.Next()).ToList();
            List<string> answersList = ListOfQuestions.Where(w => w.QuestionNumber == currentQuestion)
                                                      .Select(s => s.CorrectAnswer)
                                                      .ToList()
                                                      .Concat(ListOfQuestions.Where(w => w.QuestionNumber == currentQuestion)
                                                                             .SelectMany(s => s.FakeAnswers)
                                                                             .ToList()).ToList();

            lblQuestion.Text = ListOfQuestions.Where(w => w.QuestionNumber == currentQuestion).Select(s => s.Question).FirstOrDefault();
            gbProgress.Text = $"Pytanie {currentQuestion} z {maxQuestions}";

            for (int i = 0; i < 4; i++)
            {
                RadioButton temp = Controls.Find($"rbAnswer{controlsSequence.ElementAt(i)}", true).First() as RadioButton;
                temp.Text = answersList.ElementAt(i);
            }
        }

        private bool RadioValidation()
        {
            try
            {
                bool validation = true;
                string message = "";
                var v = gbAnswers.Controls.OfType<RadioButton>().FirstOrDefault(ch => ch.Checked);
                if (v == null)
                {
                    message += "Zaznacz odpowiedź!\n";
                    validation = false;
                }

                if (!validation)
                {
                    MessageBox.Show(message);
                }
                return validation;
            }
            catch (Exception ex)
            {
                throw new Exception("Walidacja zaznaczenia.", ex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (RadioValidation())
            {
                if (currentQuestion < maxQuestions)
                {
                    UpdatePlayerStatus();
                    currentQuestion++;
                    pbQuestions.PerformStep();
                    SetupControls();
                }
                else
                {
                    UpdatePlayerStatus();
                    pbQuestions.PerformStep();
                    MessageBox.Show(Player.ToString());
                    this.Close();
                }
            }
            
            
        }
    }
}
