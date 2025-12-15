using eb7429u20211c221.Product.Domain.Model.Aggregates;
using eb7429u20211c221.Product.Domain.Repositories;
using eb7429u20211c221.Shared.Infrastructure.Persistence.EFC.Configuration;
using eb7429u20211c221.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace eb7429u20211c221.Product.Infrastructure.Persistence.EFC.Repositories;

public class ProductRepository (AppDbContext context) : BaseRepository<Products>(context), IProductRepository
{
    
}