using SQLite;
using ExaminationApp.Models;
using Microsoft.Maui.ApplicationModel.Communication;
namespace ExaminationApp;

public class PostRepository
{
    string _dbPath;


    public List<PostRecord> DashboardPosts {  get; set; }

    public string StatusMessage { get; set; }

    private SQLiteAsyncConnection conn;

    //Initialises a Post table using the PostRecord Class
    private async Task Init()
    {
        //If the table already Exists do nothing
        if (conn != null)
            return;

        conn = new SQLiteAsyncConnection(_dbPath);

        await conn.CreateTableAsync<PostRecord>();
    }

    public PostRepository(string dbPath)
    {
        _dbPath = dbPath;
    }

    //Adds a User to the User table
    public async Task AddNewPost(string title, string body, string type, int userID)
    {
        int result = 0;
        try
        {
            await Init();

            //Inserts post to the post table
            result = await conn.InsertAsync(
                new PostRecord {
                    Title = title,
                    Body = body,
                    PostType = (PostType)Enum.Parse(typeof(PostType), type),
                    UserID = userID
                });
            result = 0;

            StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, title);
        }
        catch (Exception ex)
        {
            StatusMessage = string.Format("Failed to add {0}. Error: {1}", title, ex.Message);
        }

    }

    //A method to get all users from the User table
    public async Task<List<PostRecord>> GetAllPosts()
    {
        try
        {
            await Init();
            return await conn.Table<PostRecord>().ToListAsync();
        }
        catch (Exception ex)
        {
            StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
        }

        return new List<PostRecord>();
    }

    //Gets the posts of the user that is logged in to the system
    public async Task<List<PostRecord>> GetDashboardPosts()
    {
        try
        {
            await Init();
            //Query gets posts baed on if the posts user id is the same as the logged in users id
            var posts = await (from p in conn.Table<PostRecord>()
                         where p.UserID == App.LoginUser.Id
                         select p).ToListAsync();
            DashboardPosts = posts;
            return posts;
        }

        catch (Exception ex)
        {
            StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
        }

        return new List<PostRecord>();
    }
}