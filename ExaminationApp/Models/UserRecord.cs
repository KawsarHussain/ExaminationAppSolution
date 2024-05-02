using SQLite;

namespace ExaminationApp.Models;

[Table("User")]
public class UserRecord
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; }

    [MaxLength(150)]
    public string FirstName { get; set; }
    
    [MaxLength(150)]
    public string LastName { get; set; }

    [MaxLength(150)]
    public string OtherName { get; set; }

    public Title Title { get; set; }
    
    public string EmailAddress { get; set; }

    public string Password { get; set; }

    public bool VerifiedEmail { get; set; }

    public string TelephoneNumber { get; set; }

    public UserType UserType { get; set; }
}
