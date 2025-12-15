using System.Net.Mime;
using eb7429u20211c221.Product.Domain.Model.Commands;
using eb7429u20211c221.Product.Domain.Services;
using eb7429u20211c221.Product.Interfaces.REST.Resources;
using eb7429u20211c221.Product.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace eb7429u20211c221.Product.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Product Management endpoints")]  
public class ProductsController (IProductCommandService productCommandService) : ControllerBase
{
    [HttpPost]
    [SwaggerOperation("Create a hotel", OperationId = "CreateHotel")]
    [SwaggerResponse(201, "Hotel created", typeof(ProductResource))]
    public async Task<IActionResult> CreateHotel([FromBody] CreateProductCommand command)
    {
        var product = await productCommandService.Handle(command);
        var resource = ProductResourceFromEntityAssembler.ToResourceFromEntity(product!);
        return Created(string.Empty, resource);
    }
}
