using eb7429u20211c221.Product.Domain.Model.ValueObjects;

namespace eb7429u20211c221.Product.Domain.Model.Commands;

public record CreateProductCommand(string productName,
                                   string category,
                                   string contactEmail,
                                   string contactPhone,
                                   AvailabilityStatus availabilityStatus,
                                   bool isSmartProduct,
                                   int ageRangeMinMonths,
                                   int ageRangeMaxMonths);

