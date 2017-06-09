using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishQuiz
{
    public static class StaticUtils
    {
        public static bool IsBetween(this decimal score, decimal from, decimal to)
        {
            return score >= from && score <= to ? true : false;
        }
    }
}
