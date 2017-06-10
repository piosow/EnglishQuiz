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
    public partial class fMain : Form
    {
        public Player CurrentPlayer = new Player();
        public fMain()
        {
            try
            {
                InitializeComponent();
                DataManager.Setup();
                FillListBox();
                QuestionClass aa = new QuestionClass();
                aa.GenerateQuestions(10, DataManager.QuizCategories.First());
            }
            catch (Exception ex)
            {
                throw new Exception("Ładowanie głównej formatki.", ex);
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (ValidateStart())
            {
                fQuiz quizForm = new fQuiz(GetSelectedCategory(), ref CurrentPlayer);
                quizForm.Show();
            }
        }

        private Category GetSelectedCategory()
        {
            string name = lbCategories.SelectedItem.ToString();
            return DataManager.QuizCategories.FirstOrDefault(f => f.CategoryName == name);
        }

        private void GeneratePlayer()
        {
            try
            {
                if (CurrentPlayer.Nick == null || !CurrentPlayer.Nick.Equals(txtNick.Text))
                {
                    CurrentPlayer = new Player(txtNick.Text);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Utowrzenie gracza.", ex);
            }
        }

        private void FillListBox()
        {
            try
            {
                foreach (Category cat in DataManager.QuizCategories)
                {
                    lbCategories.Items.Add(cat.CategoryName);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Napełenienie kategorii.", ex);
            }
        }

        private bool ValidateStart()
        {
            try
            {
                bool validation = true;
                string message = "";
                if (txtNick.Text.Length == 0)
                {
                    message += "Podaj nick!\n";
                    validation = false;
                }
                if (lbCategories.SelectedItems.Count == 0)
                {
                    message += "Wybierz kategorię quizu!\n";
                    validation = false;
                }

                if (!validation)
                {
                    MessageBox.Show(message);
                }
                else
                {
                    GeneratePlayer();
                }

                return validation;
            }
            catch (Exception ex)
            {
                throw new Exception("Walidacja startu.", ex);
            }
        }
    }
}
