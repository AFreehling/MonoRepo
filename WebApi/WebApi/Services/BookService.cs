using WebApi.Model;

namespace WebApi.Services
{
    public class BookService : IBookService
    {
        public BookService() { }

        public IEnumerable<BookDto> GetBooks()
        {
            var books = new List<BookDto>()
            {
                new BookDto
                {
                    Id = 1,
                    Title = "Test",
                    Author = "Mr. Book",
                    Description = "Test",
                }
            };

            return books;
        }
    }
}
