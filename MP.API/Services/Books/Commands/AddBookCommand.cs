using MediatR;
using MP.API.Entities;

namespace MP.API.Services.Books.Commands;

public record AddBookCommand(long Id,string Name):IRequest<Book>;