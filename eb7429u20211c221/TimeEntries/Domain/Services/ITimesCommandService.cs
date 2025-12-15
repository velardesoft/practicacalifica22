using eb7429u20211c221.TimeEntries.Domain.Model.Aggregates;
using eb7429u20211c221.TimeEntries.Domain.Model.Commands;

namespace eb7429u20211c221.TimeEntries.Domain.Services;

public interface ITimesCommandService
{
    Task<Times?> Handle(CreateTimesCommand command);
}