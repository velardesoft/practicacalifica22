using eb7429u20211c221.TimeEntries.Domain.Model.ValueObjects;

namespace eb7429u20211c221.TimeEntries.Domain.Model.Aggregates;

public partial class Times
{
    
    public int Id { get; set; }
    public int ProjectId { get; private set; }
    public int UserId { get; private set; }
    public string Description { get; private set; }
    public int DurationMinutes { get; private set; }
    public EEntryStatus EntryStatus { get; private set; }
    public string CreatedBy { get; private set; }
    public DateTime StartedAt { get; private set; } 
    
    protected Times()
    {
        ProjectId = 0;
        UserId = 0;
        Description = string.Empty;
        DurationMinutes = 0;
        EntryStatus = EEntryStatus.RUNNING; 
        CreatedBy = string.Empty;
        StartedAt = DateTime.UtcNow;
    }
    
    public Times(int projectId, int userId, string description, int durationMinutes,
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
}