using eb7429u20211c221.TimeEntries.Domain.Model.Aggregates;
using eb7429u20211c221.TimeEntries.Interfaces.REST.Resources;

namespace eb7429u20211c221.TimeEntries.Interfaces.REST.Transform;

public class TimesResourceFromEntityAssembler
{
    public static TimesResource ToResourceFromEntity(Times entity) =>
        new TimesResource(entity.Id, entity.ProjectId, entity.UserId, entity.Description, entity.DurationMinutes,
            entity.EntryStatus, entity.CreatedBy, entity.StartedAt);
}