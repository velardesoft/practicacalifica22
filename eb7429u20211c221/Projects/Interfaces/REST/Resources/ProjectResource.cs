using eb7429u20211c221.Projects.Domain.Model.ValueObjects;

namespace eb7429u20211c221.Projects.Interfaces.REST.Resources;

public record ProjectResource(
    int Id,
    int WorkSpaceId,
    string Name,
    bool Billable,
    EProjectStatus Status
    );