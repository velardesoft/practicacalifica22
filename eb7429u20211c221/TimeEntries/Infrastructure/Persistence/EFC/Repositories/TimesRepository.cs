using eb7429u20211c221.Shared.Infrastructure.Persistence.EFC.Configuration;
using eb7429u20211c221.Shared.Infrastructure.Persistence.EFC.Repositories;
using eb7429u20211c221.TimeEntries.Domain.Model.Aggregates;
using eb7429u20211c221.TimeEntries.Domain.Repositories;

namespace eb7429u20211c221.TimeEntries.Infrastructure.Persistence.EFC.Repositories;

public class TimesRepository (AppDbContext context) : BaseRepository<Times>(context), ITimesRepository
{
    
}