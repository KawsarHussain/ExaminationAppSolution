using System.ComponentModel.DataAnnotations;

namespace ExaminationApp.Models;

public class Student : User
{
    
    #region Attributes

    private List<int> _listofCourses;

    #endregion

    #region Getters and Setters

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
        this._listofCourses = new List<int>();
    }

    //Constructor for generating Student classes when loading it from database
    public Student(
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
        _listofCourses = listOfCourses;
    }

    #endregion

}
