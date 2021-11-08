using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRespository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById (int id)
        {
            return DataSource().Where(ex => ex.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(ex => ex.Title.Contains(title)  || ex.Author.Contains(authorName)).ToList();

        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title="C++",Author= "Gulzar"},
                new BookModel(){Id = 2, Title="C#",Author= "Gulzar"},
                new BookModel(){Id = 3, Title="MVC",Author= "Gulzar"},
                new BookModel(){Id = 4, Title="JAVA",Author= "Gulzar"},
                new BookModel(){Id = 5, Title="Python",Author= "Gulzar"},
                new BookModel(){Id = 6, Title="C",Author= "Gulzar"},
                new BookModel(){Id = 7, Title="Asp.net",Author= "Gulzar"},
                new BookModel(){Id = 8, Title="PHP",Author= "Gulzar"},
                new BookModel(){Id = 9, Title="F#",Author= "Gulzar"},
                new BookModel(){Id = 10, Title="VB",Author= "Gulzar"},
            };
        }
    }
}
