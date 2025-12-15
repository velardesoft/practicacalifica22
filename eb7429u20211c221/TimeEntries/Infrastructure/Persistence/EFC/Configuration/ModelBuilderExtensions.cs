using eb7429u20211c221.TimeEntries.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace eb7429u20211c221.TimeEntries.Infrastructure.Persistence.EFC.Configuration;

public static class ModelBuilderExtensions
{
    public static void ApplyTimesConfiguration(this ModelBuilder builder)
    {
        builder.Entity<Times>().HasKey(x => x.Id);
        builder.Entity<Times>().Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Times>().Property(x => x.UserId).IsRequired();
        builder.Entity<Times>().Property(x => x.ProjectId).IsRequired();
        builder.Entity<Times>().Property(x => x.Description).IsRequired();
        builder.Entity<Times>().Property(x => x.DurationMinutes).IsRequired();
        builder.Entity<Times>().Property(x => x.EntryStatus).IsRequired();
        builder.Entity<Times>().Property(x => x.CreatedBy).IsRequired();
        builder.Entity<Times>().Property(x => x.StartedAt).IsRequired();
    }
}