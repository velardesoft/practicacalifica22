using pc27429u20211c221.Product.Domain.Model.Aggregates;
using pc27429u20211c221.Product.Domain.Model.Commands;

namespace pc27429u20211c221.Product.Domain.Services;

public interface IProductCommandService
{
    Task<Products?> Handle(CreateProductCommand command);
}