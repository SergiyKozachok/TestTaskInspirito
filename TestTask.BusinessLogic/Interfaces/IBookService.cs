using System.Collections.Generic;
using TestTask.BusinessLogic.Models;

namespace TestTask.BusinessLogic.Interfaces
{
    public interface IBookService
    {
        RequestResult<List<BookModel>> GetBooks();
        RequestResult<BookModel> GetBookById(int id);
        RequestResult<BookModel> AddBook(AddBookModel book);
        RequestResult<BookModel> UpdateBook(BookModel book);
        RequestResult DeleteBook(int id);
    }
}
