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
    public async Task AddNewUser(
        string firstName, 
        string lastName, 
        string otherName,
        string title,
        string emailaddress,
        string password,
        string telephoneNumber,
        string userType)
    {
        int result = 0;
        try
        {
            await Init();
            //Inserts user to the User table
            result = await conn.InsertAsync(
                new UserRecord { 
                    FirstName = firstName, 
                    LastName = lastName, 
                    OtherName = otherName,
                    Title = (Title)Enum.Parse(typeof(Title),title),
                    EmailAddress = emailaddress,
                    Password = password,
                    TelephoneNumber = telephoneNumber,
                    UserType = (UserType)Enum.Parse(typeof(UserType),userType)
                });
            result = 0;

            StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, firstName);
        }
        catch (Exception ex)
        {
            StatusMessage = string.Format("Failed to add {0}. Error: {1}", firstName, ex.Message);
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

    //A method to get a specific user from the User table based on a username and password

    public async Task<UserRecord> GetUser(string  email, string password)
    {
        try
        {
            await Init();
            //Uses a Linq statement to select a user based on if the 
            var user = from u in conn.Table<UserRecord>()
                       where u.EmailAddress.ToLower() == email.ToLower() && u.Password == password
                       select u;
            return await user.FirstOrDefaultAsync();
        }
        catch (Exception ex)
        {

            StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
        }
        return new UserRecord();
    }
}
