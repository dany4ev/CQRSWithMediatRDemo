using CQRSWithMediatR.EF_Models;
using CQRSWithMediatR.Models;
using CQRSWithMediatR.Queries;
using MediatR;

namespace CQRSWithMediatR.Handlers;

public class GetProductQueryHandler(ApplicationDbContext context) : IRequestHandler<GetProductQuery, ProductDto>
{
    public async Task<ProductDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var productDto = new ProductDto();
        var product = await context.Products.FindAsync(request.Id);
        if (product != null)
        {
            productDto = new ProductDto {Id = product.Id, Name = product.Name, Price = product.Price};
        }
        return productDto;
    }
}