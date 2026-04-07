using ReadProject.ApiService.Extensions;
using ReadProject.ApiService.Infrastructure;
using ReadProject.Application.Abstraction.Messaging;
using ReadProject.Application.Features.Todos.Get;
using ReadProject.SharedKernel;

namespace ReadProject.ApiService.Endpoints.Todos;

public sealed class Get : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("todos", async (
                Guid userId,
                IQueryHandler<GetTodosQuery, List<TodoResponse>> handler,
                CancellationToken cancellationToken) =>
            {
                var query = new GetTodosQuery(userId);

                Result<List<TodoResponse>> result = await handler.Handle(query, cancellationToken);

                return result.Match(Results.Ok, CustomResult.Problem);
            })
            .WithTags(Tags.Todos)
            .RequireAuthorization();
    }
}