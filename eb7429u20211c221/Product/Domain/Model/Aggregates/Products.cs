using eb7429u20211c221.Product.Domain.Model.ValueObjects;

namespace eb7429u20211c221.Product.Domain.Model.Aggregates;

public class Products
{
    public int Id { get; set; }
    public string productName { get; private set; }
    public string category { get; private set; }
    public string contactEmail { get; private set; }
    public string contactPhone { get; private set; }
    public AvailabilityStatus availabilityStatus { get; private set; }
    public bool isSmartProduct { get; private set; }
    public int ageRangeMinMonths { get; private set; }
    public int ageRangeMaxMonths { get; private set; }


    protected Products()
    {
        productName = string.Empty;
        category = string.Empty;
        contactEmail = string.Empty;
        contactPhone = string.Empty;
        availabilityStatus = AvailabilityStatus.Limited;
        isSmartProduct = false;
        ageRangeMinMonths = 0;
        ageRangeMaxMonths = 0;
    }

    public Products(string productName, string category, string contactEmail, string contactPhone, AvailabilityStatus availabilityStatus, 
        bool isSmartProduct, int ageRangeMinMonths, int ageRangeMaxMonths)
    {
        this.productName = productName;
        this.category = category;
        this.contactEmail = contactEmail;
        this.contactPhone = contactPhone;
        this.availabilityStatus = availabilityStatus;
        this.isSmartProduct = isSmartProduct;
        this.ageRangeMinMonths = ageRangeMinMonths;
        this.ageRangeMaxMonths = ageRangeMaxMonths;
    }
}