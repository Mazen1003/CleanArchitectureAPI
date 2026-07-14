using MediatR;

namespace CleanArchitecture.Application.Features.Products.Commands;

public record DeleteProductCommand(int Id) : IRequest<bool>;