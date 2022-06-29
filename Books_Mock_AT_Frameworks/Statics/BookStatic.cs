using Books_Mock_AT_Frameworks.Models;

namespace Books_Mock_AT_Frameworks.Statics
{
    public static class BookStatic
    {
        public static List<Book> books = new();

        public static List<Book> GetAllBooks()
        {
            return books;
        }

        public static Book GetBookById(Guid id)
        {
            var result = GetAllBooks().FirstOrDefault(x => x.Id == id);
            return result;
        }

        public static void AddBook(Book book)
        {
            book.Id = Guid.NewGuid();
            book.CreationDate = DateTime.Now;
            books.Add(book);
        }

        public static void RemoveBookById(Guid id)
        {
            books.Remove(GetBookById(id));
        }

        public static void UpdateBook(Book book)
        {
            var bookToUpdate = GetBookById(book.Id);
            bookToUpdate.Update(book);
        }
    }
}
