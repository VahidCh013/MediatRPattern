using MediatR;
using MP.API.DataStores;
using MP.API.Entities;

namespace MP.API.Services.Books.Commands;

public class AddBookCommandHandler : IRequestHandler<AddBookCommand, Book>
{
    private readonly FakeDataStore _fakeDataStore;

    public AddBookCommandHandler(FakeDataStore fakeDataStore)
    {
        _fakeDataStore = fakeDataStore;
    }

    public async Task<Book> Handle(AddBookCommand request, CancellationToken cancellationToken)
    {
        var book = new Book()
            {Id = request.Id,Name = request.Name};
        return await _fakeDataStore.AddBook(book);
    }
}