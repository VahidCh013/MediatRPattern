using MediatR;
using MP.API.Entities;

namespace MP.API.Services.Books.Queries;

public record GetAllBooksQuery():IRequest<IEnumerable<Book>>;