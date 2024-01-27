using FluentValidation;
namespace SimpleBlog.Features.Posts.EditPosts;

public class Validator : AbstractValidator<Input>
{
    public Validator()
    {
        RuleFor(input => input.Title)
        .NotEmpty()
        .WithMessage("")
        .Length(3, 10)
        .WithMessage("");

        RuleFor(input => input.Content)
            .NotEmpty();
    }

}