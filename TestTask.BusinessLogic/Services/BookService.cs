using AutoMapper;
using System;
using System.Collections.Generic;
using TestTask.BusinessLogic.Entity;
using TestTask.BusinessLogic.Interfaces;
using TestTask.BusinessLogic.Models;

namespace TestTask.BusinessLogic.Services
{
    public class BookService : IBookService
    {
        private IRepository<Book> _repositiry;

        public BookService(IRepository<Book> repository)
        {
            _repositiry = repository;
        }

        public RequestResult<List<BookModel>> GetBooks()
        {
            var result = new RequestResult<List<BookModel>>()
            {
                Result = Mapper.Map<List<Book>, List<BookModel>>(_repositiry.GetAll()),
                Success = true,
            };

            return result;
        }

        public RequestResult<BookModel> GetBookById(int id)
        {
            var result = new RequestResult<BookModel>();

            var book = _repositiry.GetById(id);
            if (book != null)
            {
                result.Result = Mapper.Map<Book, BookModel>(book);
                result.Success = true;
            }
            else
            {
                result.Message = $"Book with Id {id} not found";
            }

            return result;
        }

        public RequestResult<BookModel> AddBook(AddBookModel model)
        {
            var result = new RequestResult<BookModel>();

            var book = _repositiry.Add(Mapper.Map<AddBookModel, Book>(model));
            if (book != null)
            {
                result.Result = Mapper.Map<Book, BookModel>(book);
                result.Success = true;
            }
            else
            {
                result.Message = "Error while trying to add the book";
            }

            return result;
        }

        public RequestResult<BookModel> UpdateBook(BookModel model)
        {
            var result = new RequestResult<BookModel>();

            var book = _repositiry.Update(Mapper.Map<BookModel, Book>(model));
            if (book != null)
            {
                result.Result = Mapper.Map<Book, BookModel>(book);
                result.Success = true;
            }
            else
            {
                result.Message = $"Book with id {model.Id} does not exist";
            }

            return result;
        }

        public RequestResult DeleteBook(int id)
        {
            var result = new RequestResult();

            var book = _repositiry.DeleteById(id);
            if (book != null)
            {
                result.Success = true;
            }
            else
            {
                result.Message = $"Book with id {id} does not exist";
            }

            return result;
        }
    }
}
