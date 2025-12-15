using eb7429u20211c221.Projects.Domain.Model.Aggregates;
using eb7429u20211c221.Projects.Domain.Model.Queries;

namespace eb7429u20211c221.Projects.Domain.Services;

public interface IProjectQueryService
{
    Task<Project?> Handle(GetProjectByIdQuery query); 
    Task<IEnumerable<Project>> Handle(GetAllProjectQuery query);
}