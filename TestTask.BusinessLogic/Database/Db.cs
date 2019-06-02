using System.Collections.Generic;
using TestTask.BusinessLogic.Entity;

namespace TestTask.BusinessLogic.Database
{
    public static class Db
    {
        private static List<Book> _books = new List<Book>()
        {
            new Book(1, "To Kill a Mockingbird", "Harper Lee"),
            new Book(2, "The Unbearable Lightness of Being", "Milan Kundera"),
            new Book(3, "A Clockwork Orange", "Anthony Burgess"),
            new Book(4, "One Hundred Years of Solitude", "Gabriel García Márquez"),
            new Book(5, "Hitchhiker's Guide to the Galaxy", "Douglas Adams"),
            new Book(6, "For Whom the Bell Tolls", "Ernest Hemingway"),
            new Book(7, "Brave New World", "Aldous Huxley"),
            new Book(8, "The Wasp Factory", "Iain Banks"),
            new Book(9, "All Quiet on the Western Front", "Erich Maria Remarque"),
            new Book(10, "Of Mice and Men", "John Steinbeck"),
        };

        public static Table<Book> Books = new Table<Book>(_books);

    }
}
