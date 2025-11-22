using pc27429u20211c221.Product.Domain.Model.Aggregates;
using pc27429u20211c221.Product.Domain.Model.Commands;
using pc27429u20211c221.Product.Domain.Repositories;
using pc27429u20211c221.Product.Domain.Services;
using pc27429u20211c221.Shared.Domain.Repositories;

namespace pc27429u20211c221.Product.Application.Internal.CommandServices;

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