using ReadProject.Domain.Users;

namespace ReadProject.Application.Abstraction.Authentication;

public interface ITokenProvider
{
    string Create(User user);
}