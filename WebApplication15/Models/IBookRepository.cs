using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication15.Models
{
    internal interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        Book AddBook(Book book);
        void UpdateBook(Book book, int id);
        void DeleteBook(int id);
    }
}
