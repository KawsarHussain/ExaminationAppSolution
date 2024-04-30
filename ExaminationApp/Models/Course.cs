namespace ExaminationApp.Models;

public class Course
{
    #region Attributes

    private uint _courseId;
    private string _courseName;
    private string _courseDescription;
    private int _credits;
    private int _duration;
    private CourseType _typeOfCourse;
    private List<CoursePost> _listOfPosts;



    #endregion

    #region Getters and Setters

    public uint CourseId
    {
        get { return _courseId; }
    }

    public string CourseName
    {
        get { return _courseName; }
        set { _courseName = value; }
    }

    public string CourseDescription
    {
        get { return _courseDescription; }
        set { _courseDescription = value; }
    }

    public int CourseCredits
    {
        get { return _credits; }
        set { _credits = value; }
    }

    public int CourseDuration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public CourseType TypeOfCourse
    {
        get { return _typeOfCourse; }
    }

    public List<CoursePost> ListOfPost
    {
        get { return _listOfPosts; }
        set { _listOfPosts = value; }
    }


    #endregion

    #region Constructors

    //Constructor for courses when getting loading it from database
    public Course(
        uint courseId,
        string courseName,
        string courseDescription,
        int credits,
        int duration,
        CourseType typeOfCourse
    )
    {
        _courseId = courseId;
        _courseName = courseName;
        _courseDescription = courseDescription;
        _credits = credits;
        _duration = duration;
        _typeOfCourse = typeOfCourse;
        _listOfPosts = new List<CoursePost>();
    }

    #endregion
}
