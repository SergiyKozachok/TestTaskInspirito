using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestTask.BusinessLogic.Database;
using TestTask.BusinessLogic.Entity;
using TestTask.BusinessLogic.Interfaces;

namespace TestTask.BusinessLogic.Repositories
{
    public class InMemoryRepository : IRepository<Book>
    {
        ///public Mock<IRepository> mockRepo = new Mock<IRepository>();
        public InMemoryRepository()
        {
        }

        public Book Add(Book book)
        {
            return Db.Books.Add(book);
        }

        public Book DeleteById(int id)
        {
            return Db.Books.Delete(id);
        }

        public List<Book> GetAll()
        {
            return Db.Books.GetAll().ToList();
        }

        public Book GetById(int id)
        {
            return Db.Books.GetById(id);
        }

        public Book Update(Book book)
        {
            return Db.Books.Update(book);
        }
    }
}
