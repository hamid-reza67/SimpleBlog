using System.Data;
using Dapper;
using System.Linq;

namespace SimpleBlog.Features.Posts.GetAllPosts;

public class AppService
{
    private readonly IDbConnection _connection;

    public AppService(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task<IEnumerable<Response>> Handler(int page,int pageSize){
        return await _connection.QueryAsync<Response>(
            "SELECT Id, Title, Content FROM Posts");
    }
}