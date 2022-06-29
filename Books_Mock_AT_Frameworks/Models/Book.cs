namespace Books_Mock_AT_Frameworks.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public BookGenre Genre { get; set; }
        public string Description { get; set; }

        public Book()
        {
        }

        public Book(Guid id, string title, DateTime creationDate, BookGenre genre, string description = "")
        {
            Id = id;
            Title = title;
            CreationDate = creationDate;
            Genre = genre;
            Description = description;
        }

        public Book(string title, DateTime creationDate, BookGenre genre, string description = "")
        {
            Title = title;
            CreationDate = creationDate;
            Genre = genre;
            Description = description;
        }

        public void Update(Book book)
        {
            Title = book.Title;
            CreationDate = book.CreationDate;
            Genre = book.Genre;
            Description = book.Description;
        }
    }

    public enum BookGenre
    {
        Aventura,
        Romance,
        Terror,
        Outros
    }
}
