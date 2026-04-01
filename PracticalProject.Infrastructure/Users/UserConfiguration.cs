using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticalProject.Domain.Users;

namespace PracticalProject.Infrastructure.Users;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.HasIndex(u => u.Email).IsUnique();
    }
}