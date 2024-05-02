using System.ComponentModel.DataAnnotations;

namespace ExaminationApp.Models;

public abstract class User //User type are not going to be generated
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

    private string _password;

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

    public string Password
    {
        get { return this._password; }
        set { this._password = value; }
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
        this._title = "Mr";
        this._emailAddress = "test@test.com";
        this._verifiedEmail = true;
        this._password = "Password123";
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
        string password,
        bool verifiedEmail, 
        string telephoneNumber, 
        Address address)
    {
        this._userId = userId;
        this._firstName = firstName;
        this._lastName = lastName;
        this._otherName = otherName;
        this._title = title;
        this._emailAddress = emailAddress;
        this._verifiedEmail = verifiedEmail;
        this._password = password;
        this._telephoneNumber = telephoneNumber;
        this._address = address;
    }

    #endregion
}
