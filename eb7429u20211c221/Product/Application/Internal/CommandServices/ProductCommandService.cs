using eb7429u20211c221.Product.Domain.Model.Aggregates;
using eb7429u20211c221.Product.Domain.Model.Commands;
using eb7429u20211c221.Product.Domain.Repositories;
using eb7429u20211c221.Product.Domain.Services;
using eb7429u20211c221.Shared.Domain.Repositories;

namespace eb7429u20211c221.Product.Application.Internal.CommandServices;

public class ProductCommandService (IProductRepository productRepository, IUnitOfWork unitOfWork) : IProductCommandService
{
    public async Task<Products?> Handle(CreateProductCommand command)
    {
        var product = new Products(command.productName, command.category, command.contactEmail, command.contactPhone,
            command.availabilityStatus, command.isSmartProduct, command.ageRangeMinMonths, command.ageRangeMaxMonths);
        await productRepository.AddAsync(product);
        await unitOfWork.CompleteAsync();
        return product;
    }
}