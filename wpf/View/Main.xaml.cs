using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using wpf.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace wpf.View
{
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            Start();
      
        }
        private int CountPage()
        {
            var sql = "select COUNT(*)  from Books;";
            return db.Query<int>(sql).FirstOrDefault(); ;
        }
        private List<Books> book { get; set; }
        private List<Author> author { get; set; }
        private int pageCount { get; set; }
        private int Pagemincount { get; set; } = 10;
        private bool isok = true;
        public IEnumerable<Books> GetAllBooks()
        {
            string sql = "";
            if (isok)
            {
                isok = false;
                pageCount = CountPage();
                
            }
          
            if (pageCount < 50)
            {
                 sql = "SELECT  * FROM Books;";
                return db.Query<Books>(sql);
            }
            else
            {
                  if (pageCount >= Pagemincount)
                  {
                        sql = $"SELECT TOP({Pagemincount.ToString()}) * FROM Books;";
                        Pagemincount += 10;
                        return db.Query<Books>(sql);
                  }
                  else
                  {
                    int num = pageCount - Pagemincount;
                    Pagemincount =+ num;
                    sql = $"SELECT TOP({Pagemincount.ToString()}) * FROM Books;";
                    return db.Query<Books>(sql);
                  }
 
            }
              return db.Query<Books>(sql);
        }
        private bool AuthorSearch(Books bk,string txt)
        {

            var sql = "SELECT * FROM Authors WHERE Id = @Id;";
            Author a = db.Query<Author>(sql, new { @Id = bk.Id_Author }).FirstOrDefault();
            string FullName = a.LastName+" "+a.FirstName;
            if (FullName.ToLower().Contains(txt)) return true;
            return false;
            
        }
        public IEnumerable<Author> GetAllAuthor(List<Books> bk)
        {
            List<Author> aut = new List<Author>();
            foreach (var item in bk)
            {
                  var sql = "SELECT * FROM Authors WHERE Id = @Id;";
                Author a = db.Query<Author>(sql, new { @Id = item.Id_Author }).FirstOrDefault();
                if (a != null)
                {
                    aut.Add(a);
                }
               
            }
            return aut;
        }
        private void Start()
        {
            db = new SqlConnection();
            db.ConnectionString = @"Data Source=NIHAD; Initial Catalog=Library; Integrated Security=SSPI";
            book = GetAllBooks().ToList();
            author = GetAllAuthor(book).ToList();
            MyFunction();
        }
        private IDbConnection db;
        private void MyFunction(List<Books> bkk = null)
        {
            Book_list.Children.Clear();
            if (bkk==null)
            {
                foreach (var item in book)
                {
                    BookControl bk = new(item);
                    ToolTip a = new ToolTip();
                    Author au = author.Find(x => x.Id == item.Id_Author);
                    a.Content = au.FirstName+" "+au.LastName;
                    bk.ToolTip = a;
                    bk.Margin = new Thickness(20, 10, 5, 10);
                    Book_list.Children.Add(bk);
                }
            }
            else
            {
                foreach (var item in bkk)
                {
                    BookControl bk = new(item);
                    ToolTip a = new ToolTip();
                    Author au = author.Find(x => x.Id == item.Id_Author);
                    a.Content = au.FirstName + " " + au.LastName;
                    bk.ToolTip = a;
                    bk.Margin = new Thickness(20, 10, 5, 10);
                    Book_list.Children.Add(bk);
                }
            }
        }
        private bool Search_Method( string txt, Books bk)
        {
            if (bk.Name.ToLower().Contains(txt.ToLower()))
            {
             //   MessageBox.Show(bk.Name, txt);
                return true;
            }
            else
            {
                return AuthorSearch(bk, txt.ToLower());
            }
        }
        private void Search_textbox_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (Search_textbox.Text=="")
            {
                MyFunction();
            }
            else if  (Search_textbox.Text.Length!=null && Search_textbox.Text!=" ")
            {
               // MessageBox.Show("A");
                List<Books> bks = new List<Books>();
                foreach (var item in book)
                {
                    if (Search_Method(Search_textbox.Text,item))
                    {
                        bks.Add(item);
                    }
                }
                if (bks.Count!=0)
                {
                    //MessageBox.Show("He");
                    MyFunction(bks);
                }
            }
            return;
        }
    }
}
