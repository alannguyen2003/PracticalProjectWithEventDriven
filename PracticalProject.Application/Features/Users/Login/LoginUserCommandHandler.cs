using Microsoft.EntityFrameworkCore;
using PracticalProject.Application.Abstraction.Authentication;
using PracticalProject.Application.Abstraction.Data;
using PracticalProject.Application.Abstraction.Messaging;
using PracticalProject.Domain.Users;
using PracticalProject.SharedKernel;

namespace PracticalProject.Application.Features.Users.Login;

public sealed class LoginUserCommandHandler(
    IApplicationDbContext context,
    IPasswordHasher passwordHasher,
    ITokenProvider tokenProvider) : ICommandHandler<LoginUserCommand, string>
{
    public async Task<Result<string>> Handle(LoginUserCommand command, CancellationToken cancellationToken)
    {
        User? user = await context.Users
            .AsNoTracking()
            .SingleOrDefaultAsync(u => u.Email == command.Email, cancellationToken);

        if (user is null)
        {
            return Result.Failure<string>(UserErrors.NotFoundByEmail);
        }

        bool verified = passwordHasher.Verify(command.Password, user.PasswordHash);

        if (!verified)
        {
            return Result.Failure<string>(UserErrors.NotFoundByEmail);
        }

        string token = tokenProvider.Create(user);
        
        return token;
    }
}