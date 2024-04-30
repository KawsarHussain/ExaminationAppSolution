using System.ComponentModel.DataAnnotations;

namespace ExaminationApp.Models;

public class CoursePost
{

    #region Attributes

    [Key]
    private uint _postID;
    private string _title;
    private string _body;
    private PostType _postType;



    #endregion

    #region Getters and Setters

    public uint PostID
    {
        get { return _postID; }
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Body
    {
        get { return _body; }
        set { _body = value; }
    }

    public PostType PostType
    {
        get { return _postType; }
        set { _postType = value; }
    }


    #endregion

    #region Constructor

    //Constructor for CoursePost when loading from database
    public CoursePost(uint postID, string title, string body, PostType postType)
    {
        _postID = postID;
        _title = title;
        _body = body;
        _postType = postType;
    }

    //Constructor for new CoursePost
    public CoursePost(string title, string body, PostType postType)
    {
        _postID = (uint) new Random().Next();
        _title = title;
        _body = body;
        _postType = postType;
    }
    #endregion

}