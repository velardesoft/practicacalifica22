using eb7429u20211c221.Projects.Domain.Model.Aggregates;
using eb7429u20211c221.Projects.Domain.Repositories;
using eb7429u20211c221.Shared.Infrastructure.Persistence.EFC.Configuration;
using eb7429u20211c221.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace eb7429u20211c221.Projects.Infrastructure.Persistence.EFC.Repositories;

public class ProjectRepository (AppDbContext context) : BaseRepository<Project>(context), IProjectRepository
{
    
}