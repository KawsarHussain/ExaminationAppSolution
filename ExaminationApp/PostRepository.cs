using SQLite;
using ExaminationApp.Models;
namespace ExaminationApp;

public class PostRepository
{
    string _dbPath;

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
    public async Task AddNewPost(string title)
    {
        int result = 0;
        try
        {
            await Init();

            //Bbasic validation to ensure a name was entered
            if (string.IsNullOrEmpty(title))
                throw new Exception("Valid name required");

            //Inserts user to the User table
            result = await conn.InsertAsync(new PostRecord { Title = title });
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
}