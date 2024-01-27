using Dapper;
using System.Data;

namespace SimpleBlog.Features.Posts.GetPostByIds;
public class AppService
{
    private readonly IDbConnection _connection;

    public AppService(
		IDbConnection connection)
	{
		_connection = connection;
	}

	public async Task<Response> Handler(int id)
	{
		return await _connection.QueryFirstAsync<Response>(
			"SELECT Id, Title, Content FROM Posts");
		//var post = await _dbContext.Posts.FindAsync(id)
		//	?? throw new Exception("Not Found");
		//return new Response
		//{
		//	Id = post.Id,
		//	Title = post.Title,
		//	Content = post.Content,
		//};
	}
}
