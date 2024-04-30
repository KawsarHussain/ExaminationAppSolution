using System.ComponentModel.DataAnnotations;

namespace ExaminationApp.Models;

public class Teacher : User
{
    
    #region Attributes

    private List<int> _coursesTaught;

    #endregion

    #region Getters and Setters
    public List<int> CoursesTaught
    {
        get { return this._coursesTaught; }
        set { this._coursesTaught = value; }
    }

    #endregion

    #region Constructors

    //Test Constructor
    public Teacher() : base()
    {
        this._coursesTaught = new List<int>();
    }

    //Constructor for generating Teacher classes when loading it from database
    public Teacher(
        List<int> coursesTaught,
        uint userId,
        string firstName,
        string lastName,
        string? otherName,
        string title,
        string emailAddress,
        bool verifiedEmail,
        string telephoneNumber,
        Address address
        ) 
        : base(
            userId,
            firstName,
            lastName,
            otherName,
            title,
            emailAddress,
            verifiedEmail,
            telephoneNumber,
            address
            )
    {
        _coursesTaught = coursesTaught;
    }

    #endregion

}
