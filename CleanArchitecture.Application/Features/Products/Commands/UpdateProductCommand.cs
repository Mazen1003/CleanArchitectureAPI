using MediatR;

namespace CleanArchitecture.Application.Features.Products.Commands;

public record UpdateProductCommand(
    int Id,
    string Name,
    decimal Price,
    int CategoryId
) : IRequest<bool>;
