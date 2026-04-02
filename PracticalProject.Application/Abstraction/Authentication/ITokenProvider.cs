using PracticalProject.Domain.Users;

namespace PracticalProject.Application.Abstraction.Authentication;

public interface ITokenProvider
{
    string Create(User user);
}