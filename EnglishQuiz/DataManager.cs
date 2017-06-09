using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishQuiz
{
    public static class DataManager
    {
        private static List<string> filePaths = new List<string>();
        public static List<Category> QuizCategories = new List<Category>();

        public static void Setup()
        {
            GetFilePaths();
            CreateQuizCategories();
        }
        private static void GetFilePaths()
        {
            try
            {
                foreach (string filePath in Directory.GetFiles(Directory.GetCurrentDirectory()))
                {
                    if (filePath.Contains("xls") || filePath.Contains("xlsx"))
                    {
                        filePaths.Add(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Pobranie ścieżek do exceli.", ex);
            }
        }
        private static void CreateQuizCategories()
        {
            try
            {
                if (filePaths.Count > 0)
                {
                    foreach (string path in filePaths)
                    {
                        QuizCategories.Add(CreateCategory(GetDataTableFromExcel(path), Path.GetFileNameWithoutExtension(path)));
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Brak danych do wczytania.\nUmieść pliki ze słownikami w katalogu aplikacji.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Napełnienie listy kategoriami", ex);
            }
            
        }

        private static DataTable GetDataTableFromExcel(string path)
        {
            try
            {
                string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={path};Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
                string query;
                DataTable dt = new DataTable();

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    var dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    var sheetName = dtSchema.Rows[0].Field<string>("TABLE_NAME");
                    query = $"SELECT * FROM [{sheetName}]";
                    using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        dataAdapter.Fill(ds);
                        dt = ds.Tables[0];
                    }
                    conn.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Utworzenie DataTable z Excela.", ex);
            }
            
        }

        private static Category CreateCategory(DataTable dt, string categoryName)
        {
            Category cat = new Category();
            cat.CategoryName = categoryName;
            foreach (DataRow r in dt.Rows)
            {
                cat.CategoryItems.Add(
                    new CategoryItem
                    {
                        Id = int.Parse(r[0].ToString())
                        ,PolishWord = r[1].ToString().ToLower()
                        ,EnglishWord = r[2].ToString().ToLower()
                    });
            }
            return cat;
        }
    }
}
