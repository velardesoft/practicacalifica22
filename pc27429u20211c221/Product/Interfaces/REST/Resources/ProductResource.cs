using pc27429u20211c221.Product.Domain.Model.ValueObjects;

namespace pc27429u20211c221.Product.Interfaces.REST.Resources;

public record ProductResource(
    int Id, 
    string productName,
    string category,
    string contactEmail,
    string contactPhone,
    AvailabilityStatus availabilityStatus,
    bool isSmartProduct,
    int ageRangeMinMonths,
    int ageRangeMaxMonths);