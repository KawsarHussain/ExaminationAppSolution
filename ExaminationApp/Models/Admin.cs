using System.ComponentModel.DataAnnotations;

namespace ExaminationApp.Models;

internal class Admin : User
{
    
    #region Attributes

    [Required]
    [Key]
    private uint _adminID;

    #endregion

    #region Getters and Setters

    public uint AdminID
    {
        get { return this._adminID; }
    }

    #endregion

    #region Constructors

    //Test Constructor

    public Admin() : base()
    {
        this._adminID = 0;
    }

    //Constructor for generating Admin classes when loading from databse
    public Admin(
        uint adminID,
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
        _adminID = adminID;
    }

    #endregion

}
