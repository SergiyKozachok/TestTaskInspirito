namespace TestTask.BusinessLogic.Entity
{
    public class Book : BaseEntity
    {
        public Book() { }

        public Book(int Id, string Title, string Author)
        {
            this.Id = Id;
            this.Title = Title;
            this.Author = Author;
        }

        public string Title { get; set; }

        public string Author { get; set; }
    }
}
