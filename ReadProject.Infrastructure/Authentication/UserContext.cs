using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using PracticalProject.Infrastructure.Authentication;
using ReadProject.Application.Abstraction.Authentication;

namespace ReadProject.Infrastructure.Authentication;

public class UserContext : IUserContext
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserContext(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public Guid UserId
    {
        get
        {
            var claims = _httpContextAccessor.HttpContext.User.FindFirstValue("sub");
            return _httpContextAccessor
                       .HttpContext?
                       .User
                       .GetUserId() ??
                   throw new UserContextUnavailableException();
        }
    }
}