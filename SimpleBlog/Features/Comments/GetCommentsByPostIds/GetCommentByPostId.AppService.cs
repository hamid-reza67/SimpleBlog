using Dapper;
using System.Data;

namespace SimpleBlog.Features.Comments.GetCommentsByPostIds;

public class AppService
{
    private readonly IDbConnection _connection;

    public AppService(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task<IEnumerable<Response>> Handler(int postId)
    {
        return await _connection.QueryAsync<Response>(
            "SELECT Id, FullName, Text, PostId FROM Comments WHERE PostId=@postId",postId);
    }
}
