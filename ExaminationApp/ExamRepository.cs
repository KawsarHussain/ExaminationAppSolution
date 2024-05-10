using SQLite;
using ExaminationApp.Models;
namespace ExaminationApp;

public class ExamRepository
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

    public ExamRepository(string dbPath)
    {
        _dbPath = dbPath;
    }

    //Adds a User to the User table
    public async Task AddNewExam(
        string title,
        ExamQuestions[] questions
            )
    {
        int result = 0;
        try
        {
            await Init();
            //Inserts user to the User table
            result = await conn.InsertAsync(
                new ExamRecord
                {
                    Title = title,
                    Questions = questions
                }); 
            result = 0;

            StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, title);
        }
        catch (Exception ex)
        {
            StatusMessage = string.Format("Failed to add {0}. Error: {1}", title, ex.Message);
        }

    }

    //A method to get all Exams from the Exams table
    public async Task<List<ExamRecord>> GetAllUsers()
    {
        try
        {
            await Init();
            return await conn.Table<ExamRecord>().ToListAsync();
        }
        catch (Exception ex)
        {
            StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
        }

        return new List<ExamRecord>();
    }

    //A method to get a specific user from the User table based on a username and password

    public async Task<ExamRecord> GetExam(string title)
    {
        try
        {
            await Init();
            //Uses a Linq statement to select a user based on if an Exam with that title exists
            var exam = from e in conn.Table<ExamRecord>()
                       where e.Title.ToLower() == title.ToLower()
                       select e;
            return await exam.FirstOrDefaultAsync();
        }
        catch (Exception ex)
        {

            StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
        }
        return new ExamRecord();
    }
}