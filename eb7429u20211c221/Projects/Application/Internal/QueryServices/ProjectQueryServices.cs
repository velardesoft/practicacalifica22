using eb7429u20211c221.Projects.Domain.Model.Aggregates;
using eb7429u20211c221.Projects.Domain.Model.Queries;
using eb7429u20211c221.Projects.Domain.Repositories;
using eb7429u20211c221.Projects.Domain.Services;

namespace eb7429u20211c221.Projects.Application.Internal.QueryServices;

public class ProjectQueryServices (IProjectRepository projectRepository) : IProjectQueryService
{
    public async Task<Project?> Handle(GetProjectByIdQuery query) => await projectRepository.FindByIdAsync(query.Id);
    public async Task<IEnumerable<Project>> Handle(GetAllProjectQuery query) => await projectRepository.ListAsync(); 
}