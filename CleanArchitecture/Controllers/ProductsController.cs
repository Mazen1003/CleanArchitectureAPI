using CleanArchitecture.Application.Features.Products.Commands;
using CleanArchitecture.Application.Features.Products.Queries;
using CleanArchitecture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }


    // GET: api/products
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetAll()
    {
        var products = await _mediator.Send(new GetAllProductsQuery());

        return Ok(products);
    }


    // GET: api/products/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetById(int id)
    {
        var product = await _mediator.Send(new GetProductByIdQuery(id));

        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }


    // POST: api/products
    [HttpPost]
    public async Task<ActionResult> Create(CreateProductCommand command)
    {
        var id = await _mediator.Send(command);

        return CreatedAtAction(
            nameof(GetById),
            new { id = id },
            command);
    }


    // PUT: api/products/5
    [HttpPut("{id}")]
    public async Task<ActionResult> Update(
        int id,
        UpdateProductCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        var result = await _mediator.Send(command);

        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }


    // DELETE: api/products/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _mediator.Send(
            new DeleteProductCommand(id));

        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }
}
