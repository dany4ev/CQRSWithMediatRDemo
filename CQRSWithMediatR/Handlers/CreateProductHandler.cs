using CQRSWithMediatR.EF_Models;
using CQRSWithMediatR.Models;
using MediatR;

namespace CQRSWithMediatR.Handlers;

public class CreateProductHandler(ApplicationDbContext context) : IRequestHandler<CreateProductCommand, int>
{
    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product { Name = request.Name, Price = request.Price };
        context.Products.Add(product);
        await context.SaveChangesAsync(cancellationToken);
        return product.Id;
    }
}