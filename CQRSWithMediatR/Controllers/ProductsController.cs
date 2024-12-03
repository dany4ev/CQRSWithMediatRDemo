using CQRSWithMediatR.Models;
using CQRSWithMediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSWithMediatR.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<int> CreateProduct([FromBody] CreateProductCommand command)
    {
        return await _mediator.Send(command);
    }

    [HttpGet("{id}")]
    public async Task<ProductDto> GetProduct(int id)
    {
        return await _mediator.Send(new GetProductQuery { Id = id });
    }
}