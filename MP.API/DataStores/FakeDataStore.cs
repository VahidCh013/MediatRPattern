using MP.API.Entities;

namespace MP.API.DataStores;

public class FakeDataStore
{
    private static readonly List<Book> Books = new()
    {
        new Book {Id = 1,Name="C#"},
        new Book {Id = 2,Name="ASP.NET core"},
        new Book {Id = 3,Name="SQL Server"}
    };

    public async Task<Book> AddBook(Book book)
    {
        Books.Add(book);
        return await Task.FromResult(book);
    }
    
    public async Task<IEnumerable<Book>> GetAllBooks()
        =>await Task.FromResult(Books);
}