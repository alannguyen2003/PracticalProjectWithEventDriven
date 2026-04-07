using PracticalProject.ApiService.Endpoints.Users;
using ReadProject.ApiService.Extensions;
using ReadProject.ApiService.Infrastructure;
using ReadProject.Application.Abstraction.Messaging;
using ReadProject.Application.Features.Users.GetById;
using ReadProject.SharedKernel;

namespace ReadProject.ApiService.Endpoints.Users;

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