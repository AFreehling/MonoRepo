using WebApi.Services;

namespace ServiceTests
{
    [TestClass]
    public class BookServiceTest
    {
        private IBookService _bookService;

        public BookServiceTest()
        {
            _bookService = new BookService();
        }

        [TestMethod]
        public void TestGetBooks()
        {
            var books = _bookService.GetBooks();
            Assert.IsNotNull(books);
            Assert.AreEqual("Test", books.FirstOrDefault(x => x.Id == 1).Title);
        }
    }
}