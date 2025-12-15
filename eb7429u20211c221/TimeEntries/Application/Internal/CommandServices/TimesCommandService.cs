using eb7429u20211c221.Shared.Domain.Repositories;
using eb7429u20211c221.TimeEntries.Domain.Model.Aggregates;
using eb7429u20211c221.TimeEntries.Domain.Model.Commands;
using eb7429u20211c221.TimeEntries.Domain.Repositories;
using eb7429u20211c221.TimeEntries.Domain.Services;

namespace eb7429u20211c221.TimeEntries.Application.Internal.CommandServices;

public class TimesCommandService (ITimesRepository productRepository, IUnitOfWork unitOfWork) : ITimesCommandService
{
    public async Task<Times?> Handle(CreateTimesCommand command)
    {
        var product = new Times(command.ProjectId, command.UserId, command.Description,
            command.DurationMinutes, command.EntryStatus, command.CreatedBy, command.StartedAt);
        await productRepository.AddAsync(product);
        await unitOfWork.CompleteAsync();
        return product;
    }
}

/*
 *
 * public Times(int projectId, int userId, string description, int durationMinutes,
        EEntryStatus entryStatus, string createdBy, DateTime startedAt)
    {
        ProjectId = projectId;
        UserId = userId;
        Description = description;
        DurationMinutes = durationMinutes;
        EntryStatus = entryStatus;
        CreatedBy = createdBy;
        StartedAt = startedAt;
    }
 */