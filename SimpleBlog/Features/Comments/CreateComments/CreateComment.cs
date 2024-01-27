using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace SimpleBlog.Features.Comments.CreateComments;


[ApiController]
[Route("api/comments")]
public class CreateComment:ControllerBase
{
    private readonly AppService _createCommentAppService;
    private readonly IValidator<Input> _validator;
    public CreateComment(AppService createCommentAppService, IValidator<Input> validator)
    {
        _createCommentAppService = createCommentAppService;
        _validator = validator;
    }

    [HttpPost]
    public async Task<ActionResult> Handler([FromBody] Input input)
    {
        var validationResult = _validator.Validate(input);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.ToDictionary());
        }
        return Ok();
    }
}
