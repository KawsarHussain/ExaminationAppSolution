using System.ComponentModel.DataAnnotations;

namespace ExaminationApp.Models;

internal class Student : User
{
    
    #region Attributes

    [Required]
    [Key]
    private uint _studentID;
    private List<int> _listofCourses;

    #endregion

    #region Getters and Setters

    public uint StudentID
    {
        get { return this._studentID; }
    }

    public List<int> ListofClasses
    {
        get { return this._listofCourses; }
        set { this._listofCourses = value; }
    }

    #endregion

    #region Constructors

    //Test Constructor

    public Student() : base()
    {
        this._studentID = 0;
        this._listofCourses = new List<int>();
    }

    //Constructor for generating Student classes when loading it from database
    public Student(
        uint studentID,
        List<int> listOfCourses,
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
        _studentID = studentID;
        _listofCourses = listOfCourses;
    }

    #endregion

}
