using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRespository _bookRespository = null;
        public BookController()
        {
            _bookRespository = new BookRespository();
        }
        public List<BookModel> GetAllBooks()
        {
            return _bookRespository.GetAllBooks();
        }
        public BookModel GetBooks(int id)
        {
            return _bookRespository.GetBookById(id);
        }
        public List<BookModel> SearchBooks( string bookName, string authorName)
        {
            return _bookRespository.SearchBook(bookName, authorName);
        }
    }
}
