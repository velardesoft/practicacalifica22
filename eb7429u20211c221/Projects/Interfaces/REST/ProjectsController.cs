using System.Net.Mime;
using eb7429u20211c221.Projects.Domain.Model.Queries;
using eb7429u20211c221.Projects.Domain.Services;
using eb7429u20211c221.Projects.Interfaces.REST.Resources;
using eb7429u20211c221.Projects.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace eb7429u20211c221.Projects.Interfaces.REST;


[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Projects endpoints")]
public class ProjectsController (IProjectQueryService carQueryService) : ControllerBase
{
    [HttpGet]
    [SwaggerOperation("Get all Projects", OperationId = "GetAllProjects")]
    [SwaggerResponse(200, "Projects found", typeof(IEnumerable<ProjectResource>))]
    public async Task<IActionResult> GetAllCars()
    {
        var cars = await carQueryService.Handle(new GetAllProjectQuery());
        var resources = cars.Select(ProjectResourceFromEntityFromAssembler.ToResourceFromEntity);
        return Ok(resources);
    }

    [HttpGet("{id:int}")]
    [SwaggerOperation("Get Projects by Id", OperationId = "GetProjectsById")]
    [SwaggerResponse(200, "Projects found", typeof(ProjectResource))]
    [SwaggerResponse(404, "Projects not found")]
    public async Task<IActionResult> GetCarById(int id)
    {
        var car = await carQueryService.Handle(new GetProjectByIdQuery(id));
        return car == null ? NotFound() : Ok(ProjectResourceFromEntityFromAssembler.ToResourceFromEntity(car));
    }

}