using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class EmployeeConfiguration: IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasData(
                new Employee { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com", AuthorizationId = 1, Password = "password123" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane@example.com", AuthorizationId = 2, Password = "password456" },
                new Employee { Id = 3, FirstName = "Michael", LastName = "Johnson", Email = "michael@example.com", AuthorizationId = 2, Password = "password789" },
                new Employee { Id = 4, FirstName = "Emily", LastName = "Brown", Email = "emily@example.com", AuthorizationId = 2, Password = "password321" },
                new Employee { Id = 5, FirstName = "William", LastName = "Taylor", Email = "william@example.com", AuthorizationId = 2, Password = "password654" }
        );
    }
}