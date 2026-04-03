using Microsoft.EntityFrameworkCore;
using ReadProject.Domain.Todos;
using ReadProject.Domain.Users;

namespace ReadProject.Application.Abstraction.Data;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }
    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}