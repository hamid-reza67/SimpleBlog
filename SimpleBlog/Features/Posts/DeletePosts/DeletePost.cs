using Microsoft.AspNetCore.Mvc;

namespace SimpleBlog.Features.Posts.DeletePosts;


[ApiController]
[Route("api/posts")]
public class DeletePost:ControllerBase
{
    private readonly AppService _appService;

    public DeletePost(AppService appService)
    {
        _appService = appService;
    }

    [HttpDelete]
    public async Task<ActionResult> Handler(int id)
    {
        await _appService.Handler(id);
        return NoContent();
    }
}

