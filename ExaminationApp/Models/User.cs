using System.ComponentModel.DataAnnotations;

namespace ExaminationApp.Models;

internal abstract class User //User type are not going to be generated
{
    
    #region Attributes

    [Required]
    [Key]
    private uint _userId;

    private string _firstName;
    private string _lastName;
    private string? _otherName;
    private string _title;

    [EmailAddress]
    [Key]
    private string _emailAddress;

    private bool _verifiedEmail;

    [Phone]
    private string _telephoneNumber;

    private Address _address;

    #endregion

    #region Getters and Setters

    public uint UserId
    {
        get { return this._userId; } 
    }

    public string FirstName
    {
        get { return this._firstName; }
        set { this._firstName = value; }
    }

    public string LastName
    {
        get { return this._lastName; }
        set { this._lastName = value; }
    }

    public string? OtherName
    {
        get { return this._otherName; }
        set { this._otherName = value; }
    }

    public string Title
    {
        get { return this._title; }
        set { this._title = value; }
    }

    public string EmailAddress
    {
        get { return this._emailAddress; }
    }

    public bool VerifiedEmail
    {
        get { return this._verifiedEmail; }
    }

    public string TelephoneNumber
    {
        get { return this._telephoneNumber; }
        set { this._telephoneNumber = value; }
    }

    public Address Address
    {
        get { return this._address; }
    }

    #endregion

    #region Constructors

    //Test Constructor
    public User()
    {
        this._userId = 0;
        this._firstName = "Test";
        this._lastName = "Test";
        this._otherName = "Test";
        this._title = "Male";
        this._emailAddress = "test@test.com";
        this._verifiedEmail = true;
        this._telephoneNumber = "+1 202-456-1111";
        this._address = new Address(); //Using the test constructor for the Address class
    }

    //Constructor for 'generating' users when loading data from database
    public User(
        uint userId, 
        string firstName, 
        string lastName, 
        string? otherName, 
        string title, 
        string emailAddress, 
        bool verifiedEmail, 
        string telephoneNumber, 
        Address address)
    {
        _userId = userId;
        _firstName = firstName;
        _lastName = lastName;
        _otherName = otherName;
        _title = title;
        _emailAddress = emailAddress;
        _verifiedEmail = verifiedEmail;
        _telephoneNumber = telephoneNumber;
        _address = address;
    }

    #endregion
}
