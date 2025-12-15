using eb7429u20211c221.TimeEntries.Domain.Model.ValueObjects;

namespace eb7429u20211c221.TimeEntries.Domain.Model.Commands;

public record CreateTimesCommand(int ProjectId, int UserId, string Description, int DurationMinutes, EEntryStatus EntryStatus, 
    string CreatedBy, DateTime StartedAt);