using MediatR;
using MP.API.DataStores;
using MP.API.Entities;

namespace MP.API.Services.Books.Queries;

public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, IEnumerable<Book>>
{
    private readonly FakeDataStore _fakeDataStore;

    public GetAllBooksQueryHandler(FakeDataStore fakeDataStore)
    {
        _fakeDataStore = fakeDataStore;
    }

    public async Task<IEnumerable<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        => await _fakeDataStore.GetAllBooks();
}