using CQRSWithMediatR.Models;
using MediatR;

namespace CQRSWithMediatR.Queries;

public class GetProductQuery : IRequest<ProductDto>
{
    public int Id { get; set; }
}