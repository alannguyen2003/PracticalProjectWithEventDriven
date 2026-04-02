using PracticalProject.ApiService.Extensions;
using PracticalProject.ApiService.Infrastructure;
using PracticalProject.Application.Abstraction.Messaging;
using PracticalProject.Application.Features.Users.GetById;
using PracticalProject.SharedKernel;

namespace PracticalProject.ApiService.Endpoints.Users;

public sealed class GetById : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("users/{userId}", async (
                Guid userId,
                IQueryHandler<GetUserByIdQuery, UserResponse> handler,
                CancellationToken cancellationToken) =>
            {
                var query = new GetUserByIdQuery(userId);

                Result<UserResponse> result = await handler.Handle(query, cancellationToken);
                return result.Match(Results.Ok, CustomResult.Problem);
            })
            .HasPermission(Permissions.UsersAccess)
            .WithTags(Tags.Users);
    }
}