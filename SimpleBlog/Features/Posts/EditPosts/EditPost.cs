using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace SimpleBlog.Features.Posts.EditPosts;


[ApiController]
[Route("api/posts")]
public class EditPost:ControllerBase
{
    private readonly AppService _appService;
    private readonly IValidator<Input> _validator;


    public EditPost(
        AppService appService,
        IValidator<Input> validator)
    {
        _appService = appService;
        _validator = validator;
    }

    [HttpPut]
    public async Task<ActionResult> Handler([FromBody] Input input){
        var validationResult = _validator.Validate(input);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.ToDictionary());
        }
        await _appService.Handler(input);
        return Ok();
    }
}