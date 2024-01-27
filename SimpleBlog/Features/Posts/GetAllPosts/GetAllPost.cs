using Microsoft.AspNetCore.Mvc;


namespace SimpleBlog.Features.Posts.GetAllPosts;

[ApiController]
[Route("api/posts")]
public class GetAllPost : ControllerBase
{
    private readonly AppService _appService;

    public GetAllPost(AppService appService)
    {
        _appService = appService;
    }

    [HttpGet]
    public async Task<IActionResult> Handler(int page,int pageSize)
    {
        var res=await _appService.Handler(page,pageSize);
        return Ok(res);
    }

}