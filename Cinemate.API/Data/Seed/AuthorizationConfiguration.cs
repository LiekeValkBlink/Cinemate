using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class AuthorizationConfiguration: IEntityTypeConfiguration<Authorization>
{
    public void Configure(EntityTypeBuilder<Authorization> builder)
    {
        builder.HasData(
            new Authorization{Id = 1, Description = "Admin"},
            new Authorization{Id = 2, Description = "User"}
        );
    }
}