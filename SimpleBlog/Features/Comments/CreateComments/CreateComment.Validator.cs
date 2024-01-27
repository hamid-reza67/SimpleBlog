using FluentValidation;

namespace SimpleBlog.Features.Comments.CreateComments;

public class Validator:AbstractValidator<Input>
{
    public Validator()
    {
        RuleFor(input => input.FullName)
            .NotEmpty()
            .WithMessage("Full name is required!")
            .Length(3, 50)
            .WithMessage("");

        RuleFor(input => input.Text)
            .NotEmpty()
            .WithMessage("Text is required!")
            .Length(3, 500)
            .WithMessage("");
    }
}
