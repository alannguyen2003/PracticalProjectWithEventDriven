namespace PracticalProject.ApiService.Endpoints.Todos;

public sealed class Create : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("todos", async (
            Guid userId,
            CancellationToken cancallationToken) =>
        {
            
        });
    }
}