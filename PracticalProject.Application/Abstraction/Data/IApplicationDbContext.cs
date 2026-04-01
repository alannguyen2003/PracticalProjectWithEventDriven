using Microsoft.EntityFrameworkCore;
using PracticalProject.Domain.Todos;
using PracticalProject.Domain.Users;

namespace PracticalProject.Application.Abstraction.Data;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }
    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}