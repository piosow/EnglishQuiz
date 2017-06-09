using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishQuiz
{
    public class Category
    {
        private List<CategoryItem> _categoryItems = new List<CategoryItem>();
        public string CategoryName { get; set; }
        public List<CategoryItem> CategoryItems
        {
            get
            {
                return _categoryItems;
            }
        }
        
    }
}
