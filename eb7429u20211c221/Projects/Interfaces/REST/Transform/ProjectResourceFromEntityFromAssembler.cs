using eb7429u20211c221.Projects.Domain.Model.Aggregates;
using eb7429u20211c221.Projects.Interfaces.REST.Resources;

namespace eb7429u20211c221.Projects.Interfaces.REST.Transform;

public class ProjectResourceFromEntityFromAssembler
{
    public static ProjectResource ToResourceFromEntity(Project entity) =>
        new ProjectResource(
            entity.Id,
            entity.WorkSpaceId,
            entity.Name,
            entity.Billable,
            entity.Status
        );
}
