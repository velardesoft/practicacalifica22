using eb7429u20211c221.Product.Domain.Model.Aggregates;
using eb7429u20211c221.Product.Domain.Model.Commands;

namespace eb7429u20211c221.Product.Domain.Services;

public interface IProductCommandService
{
    Task<Products?> Handle(CreateProductCommand command);
}