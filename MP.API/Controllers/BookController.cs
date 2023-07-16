using MediatR;
using Microsoft.AspNetCore.Mvc;
using MP.API.Entities;
using MP.API.Services.Books.Commands;
using MP.API.Services.Books.Queries;

namespace MP.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly IMediator _mediator;
    public BookController(IMediator mediator) => _mediator = mediator;

    [HttpGet]
    [Route("GetAllBooks")]
    public async Task<IActionResult> GetAllBooks()
    {
        var response=await _mediator.Send(new GetAllBooksQuery());
        return Ok(response);
    }
    
    [HttpPost]
    [Route("AddBook")]
    public async Task<IActionResult> GetAllBooks([FromBody] Book book)
    {
        var response=await _mediator.Send(new AddBookCommand(book.Id,book.Name));
        return Ok(response);
    }
}