using System.ComponentModel.DataAnnotations;

namespace ExaminationApp.Models;

internal class Teacher : User
{
    
    #region Attributes

    [Required]
    [Key]
    private uint _teacherID;
    private List<int> _coursesTaught;

    #endregion


    #region Getters and Setters

    public uint TeacherID
    {
        get { return this._teacherID; }
    }

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
        this._teacherID = 0;
        this._coursesTaught = new List<int>();
    }

    //Constructor for generating Teacher classes when loading it from database
    public Teacher(
        uint teacherID,
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
        _teacherID = teacherID;
        _coursesTaught = coursesTaught;
    }

    #endregion

}
