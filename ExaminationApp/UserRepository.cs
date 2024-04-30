using SQLite;
using ExaminationApp.Models;
namespace ExaminationApp;

public class UserRepository
{
    string _dbPath;

    public string StatusMessage { get; set; }

    private SQLiteAsyncConnection conn;

    //Initialises a User table using the UserRecord Class
    private async Task Init()
    {
        //If the table already Exists do nothing
        if (conn != null)
            return;

        conn = new SQLiteAsyncConnection(_dbPath);

        await conn.CreateTableAsync<UserRecord>();
    }

    public UserRepository(string dbPath)
    {
        _dbPath = dbPath;
    }

    //Adds a User to the User table
    public async Task AddNewUser(string name)
    {
        int result = 0;
        try
        {
            await Init();

            //Bbasic validation to ensure a name was entered
            if (string.IsNullOrEmpty(name))
                throw new Exception("Valid name required");

            //Inserts user to the User table
            result = await conn.InsertAsync(new UserRecord { FirstName = name });
            result = 0;

            StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
        }
        catch (Exception ex)
        {
            StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
        }

    }

    //A method to get all users from the User table
    public async Task<List<UserRecord>> GetAllUsers()
    {
        try
        {
            await Init();
            return await conn.Table<UserRecord>().ToListAsync();
        }
        catch (Exception ex)
        {
            StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
        }

        return new List<UserRecord>();
    }
}
