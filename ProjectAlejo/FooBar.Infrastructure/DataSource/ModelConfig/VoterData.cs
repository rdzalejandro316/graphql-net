using FooBar.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FooBar.Infrastructure.DataSource.ModelConfig;

public static class VoterData
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Voter>().HasData
        (
            new Voter("1033796537", DateTime.Now, "Colombia") { Id = Guid.NewGuid() },
            new Voter("1033796537", DateTime.Now, "Peru") { Id = Guid.NewGuid() },
            new Voter("51765132", new DateTime(2024, 5, 2), "COLOMBIA") { Id = Guid.NewGuid() },
            new Voter("79254420", new DateTime(2024, 5, 2), "COLOMBIA") { Id = Guid.NewGuid() }
        );
    }

}
