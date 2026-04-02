using FluentValidation;

namespace PracticalProject.Application.Features.Todos.Copy;

public class CopyTodoCommandValidator : AbstractValidator<CopyTodoCommand>
{
    public CopyTodoCommandValidator()
    {
        RuleFor(c => c.UserId).NotEmpty();
        RuleFor(c => c.TodoId).NotEmpty();
    }
}