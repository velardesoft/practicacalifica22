using Microsoft.EntityFrameworkCore;
using pc27429u20211c221.Product.Domain.Model.Aggregates;

namespace pc27429u20211c221.Product.Infrastructure.Persistence.EFC.Configuration.Extensions;

public static class ModelBuilderExtensions
{
    public static void ApplyProductsConfiguration(this ModelBuilder builder)
    {
        builder.Entity<Products>().HasKey(p => p.Id);
        builder.Entity<Products>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Products>().Property(p => p.productName).IsRequired();
        builder.Entity<Products>().Property(p => p.category).IsRequired();
        builder.Entity<Products>().Property(p => p.contactEmail).IsRequired();
        builder.Entity<Products>().Property(p => p.contactPhone).IsRequired();
        builder.Entity<Products>().Property(p => p.availabilityStatus).IsRequired();
        builder.Entity<Products>().Property(p => p.isSmartProduct).IsRequired();
        builder.Entity<Products>().Property(p => p.ageRangeMinMonths).IsRequired();
        builder.Entity<Products>().Property(p => p.ageRangeMaxMonths).IsRequired(); 
    }
}