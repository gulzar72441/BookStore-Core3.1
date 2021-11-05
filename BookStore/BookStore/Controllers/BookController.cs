using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All Books";
        }
        public string GetBooks(int id)
        {
            return $"Book with id = {id}";
        }
        public string SearchBooks( string bookName, string authorName)
        {
            return $"Book with Name ={bookName} & Author ={authorName}";
        }
    }
}
