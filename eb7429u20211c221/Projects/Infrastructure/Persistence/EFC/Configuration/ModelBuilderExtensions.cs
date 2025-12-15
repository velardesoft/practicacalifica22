using eb7429u20211c221.Projects.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace eb7429u20211c221.Projects.Infrastructure.Persistence.EFC.Configuration;

public static class ModelBuilderExtensions
{
    public static void ApplyProjectConfiguration(this ModelBuilder builder)
    {
        // builder.Entity<Times>().HasKey(x => x.Id);
        builder.Entity<Project>().HasKey(p => p.Id);
        builder.Entity<Project>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Project>().Property(p => p.WorkSpaceId).IsRequired();
        builder.Entity<Project>().Property(p => p.Name).IsRequired().HasMaxLength(200);
        builder.Entity<Project>().Property(p => p.Billable).IsRequired();
        builder.Entity<Project>().Property(p => p.Status).IsRequired();
    }
}