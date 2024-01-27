using Microsoft.AspNetCore.Mvc;

namespace SimpleBlog.Features.Comments.GetCommentsByPostIds;


[ApiController]
[Route("api/comments")]
public class GetCommentByPostId:ControllerBase
{
    private readonly AppService _appService;

    public GetCommentByPostId(AppService appService)
    {
        _appService = appService;
    }

    [HttpGet]
    public async Task<IActionResult> Handler(int postId)
    {
        var res = await _appService.Handler(postId);
        return Ok(res);
    }
}
