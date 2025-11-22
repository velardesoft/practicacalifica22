using pc27429u20211c221.Product.Domain.Model.Aggregates;
using pc27429u20211c221.Product.Domain.Repositories;
using pc27429u20211c221.Shared.Infrastructure.Persistence.EFC.Configuration;
using pc27429u20211c221.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace pc27429u20211c221.Product.Infrastructure.Persistence.EFC.Repositories;

public class ProductRepository (AppDbContext context) : BaseRepository<Products>(context), IProductRepository
{
    
}