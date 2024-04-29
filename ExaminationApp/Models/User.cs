namespace ExaminationApp.Models;

internal class User
{
    #region Attributes

    private int _userId;
    private string _firstName;
    private string _lastName;
    private string? _otherName;
    private string _title;
    private string _emailAddress;
    private bool _verifiedEmail;
    private string _telephoneNumber;
    private Address _address;

    #endregion


    #region Getters and Setters

    public int UserId
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
}
