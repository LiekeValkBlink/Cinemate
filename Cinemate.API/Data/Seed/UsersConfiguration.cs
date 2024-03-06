using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class UsersConfiguration: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData(
            new User
            {
                Id = 1,
                Email = "user1@example.com",
                Name = "User 1",
                Password = "password123",
                SubscribedToNewsletter = true
            },
            new User
            {
                Id = 2,
                Email = "user2@example.com",
                Name = "User 2",
                Password = "password456",
                SubscribedToNewsletter = false
            },
            new User
            {
                Id = 3,
                Email = "user3@example.com",
                Name = "User 3",
                Password = "password789",
                SubscribedToNewsletter = true
            },
            new User
            {
                Id = 4,
                Email = "user4@example.com",
                Name = "User 4",
                Password = "password321",
                SubscribedToNewsletter = false
            },
            new User
            {
                Id = 5,
                Email = "user5@example.com",
                Name = "User 5",
                Password = "password654",
                SubscribedToNewsletter = true
            }
        );
    }
}