using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishQuiz
{
    public class QuestionClass
    {
        private Random random = new Random();
        public List<QuestionClass> QuizQuestions = new List<QuestionClass>();

        public int QuestionNumber { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> FakeAnswers { get; set; }
        public bool RightAnswer { get; set; }

        private QuestionClass AddQuestion(Category cat, int qNumber)
        {
            QuestionClass newQuestion = new QuestionClass();
            int randId = random.Next(cat.CategoryItems.Count);

            newQuestion.QuestionNumber = qNumber;
            newQuestion.Question = cat.CategoryItems.Where(w => w.Id == randId).Select(s => s.PolishWord).FirstOrDefault();
            newQuestion.CorrectAnswer = cat.CategoryItems.Where(w => w.Id == randId).Select(s => s.EnglishWord).FirstOrDefault();
            newQuestion.FakeAnswers = cat.CategoryItems.Where(w => w.Id != randId).OrderBy(ob => random.Next()).Select(s => s.EnglishWord).Take(3).ToList();

            return newQuestion;
        }

        public void GenerateQuestions(int size, Category cat)
        {
            int tempNumber = 1;
            while (tempNumber <= size)
            {
                QuestionClass tempQuestion = this.AddQuestion(cat, tempNumber);
                if (QuizQuestions.Any(a => a.CorrectAnswer == tempQuestion.CorrectAnswer))
                {
                    continue;
                }
                else
                {
                    QuizQuestions.Add(tempQuestion);
                    tempNumber++;
                }
            }
        }
    }
}
