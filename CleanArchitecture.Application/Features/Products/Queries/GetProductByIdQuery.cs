using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.Products.Queries;

public record GetProductByIdQuery(int Id) : IRequest<Product?>;
