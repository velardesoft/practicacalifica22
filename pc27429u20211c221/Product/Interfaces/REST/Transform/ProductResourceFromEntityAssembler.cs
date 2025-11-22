using pc27429u20211c221.Product.Domain.Model.Aggregates;
using pc27429u20211c221.Product.Interfaces.REST.Resources;

namespace pc27429u20211c221.Product.Interfaces.REST.Transform;

public class ProductResourceFromEntityAssembler
{
    public static ProductResource ToResourceFromEntity(Products entity) => 
        new ProductResource(entity.Id, entity.productName, entity.category, entity.contactEmail,
            entity.contactPhone, entity.availabilityStatus, entity.isSmartProduct,
            entity.ageRangeMinMonths, entity.ageRangeMaxMonths);
}
