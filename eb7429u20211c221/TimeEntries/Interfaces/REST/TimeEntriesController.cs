using System.Net.Mime;
using eb7429u20211c221.TimeEntries.Domain.Model.Commands;
using eb7429u20211c221.TimeEntries.Domain.Services;
using eb7429u20211c221.TimeEntries.Interfaces.REST.Resources;
using eb7429u20211c221.TimeEntries.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
namespace eb7429u20211c221.TimeEntries.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Times Management endpoints")]  
public class TimeEntriesController(ITimesCommandService timesCommandService) : ControllerBase
{
    [HttpPost]
    [SwaggerOperation("Create a Times", OperationId = "CreateTimes")]
    [SwaggerResponse(201, "Times created", typeof(TimesResource))]
    public async Task<IActionResult> CreateHotel([FromBody] CreateTimesCommand command)
    {
        var product = await timesCommandService.Handle(command);
        var resource = TimesResourceFromEntityAssembler.ToResourceFromEntity(product!);
        return Created(string.Empty, resource);
    }
}