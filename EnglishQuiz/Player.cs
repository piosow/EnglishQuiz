using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishQuiz
{
    public  class Player
    {
        public  string Nick { get; set; }

        public int Count { get; set; }

        public int CurrentCorrectAnswers { get; set; }
        public int CurrentWrongAnswers { get; set; }
        public int CurrentQuestionsCount
        {
            get
            {
                return CurrentCorrectAnswers + CurrentWrongAnswers;
            }
        }

        public  int CorrectAnswers { get; set; }

        public  int WrongAnswers { get; set; }

        public int QuestionsCount
        {
            get
            {
                return CorrectAnswers + WrongAnswers;
            }
        }
        public  int Score
        {
            get
            {
                return QuestionsCount / CorrectAnswers;
            }
        }
        public decimal Percentage
        {
            get
            {
                return ((decimal)CorrectAnswers / (decimal)QuestionsCount) * 100m;
            }
        }

        public decimal CurrentPercentage
        {
            get
            {
                return ((decimal)CurrentCorrectAnswers / (decimal)CurrentQuestionsCount) * 100m;
            }
        }

        public Player()
        {

        }

        public Player(string nick)
        {
            Nick = nick;
            Count = 0;
        }

        public void Success()
        {
            CorrectAnswers++;
        }

        public void Failure()
        {
            WrongAnswers++;
        }

        private string PlayerRank
        {
            get
            {
                if (Percentage.IsBetween(0,9.99m))
                {
                    return "D N O !!";
                }
                else if (Percentage.IsBetween(10,19.99m))
                {
                    return "Strzelnica? Nie można być tak słabym!";
                }
                else if (Percentage.IsBetween(20,29.99m))
                {
                    return "Jest źle!";
                }
                else if (Percentage.IsBetween(30,39.99m))
                {
                    return "Średniawka...";
                }
                else if (Percentage.IsBetween(40, 49.99m))
                {
                    return "Nie jest najgorzej, jednak nie zachwyca.";
                }
                else if (Percentage.IsBetween(50, 59.99m))
                {
                    return "Ostatnia granica przyzwoitości.";
                }
                else if (Percentage.IsBetween(60, 69.99m))
                {
                    return "Mogłoby być lepiej, ale i tak jest ok!";
                }
                else if (Percentage.IsBetween(70, 79.99m))
                {
                    return "Nieźle, nieźle!";
                }
                else if (Percentage.IsBetween(80, 89.99m))
                {
                    return "Dobra robota!";
                }
                else if (Percentage.IsBetween(90, 99.99m))
                {
                    return "Piękna rzecz!";
                }
                else
                {
                    return "100% kozak!";
                }
            }
        }

        public override string ToString()
        {
            string message = "";
            message += $"\t{Nick}\n";
            message += $"\nObecny quiz:\n";
            message += $"Poprawnych odpowiedzi: {CurrentCorrectAnswers}\n";
            message += $"Błędnych odpowiedzi: {CurrentWrongAnswers}\n";
            message += $"\nSkuteczność: {CurrentPercentage.ToString("F")}%";
            message += $"\n\nOgólnie ({Count}):\n";
            message += $"Poprawnych odpowiedzi: {CorrectAnswers}\n";
            message += $"Błędnych odpowiedzi: {WrongAnswers}\n";
            message += $"\nSkuteczność: {Percentage.ToString("F")}%";
            message += $"\n\n{PlayerRank}\n";
            return message;
        }
    }
}
