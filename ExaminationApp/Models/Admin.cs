using System.ComponentModel.DataAnnotations;

namespace ExaminationApp.Models;

public class Admin : User
{
    
    #region Attributes


    #endregion

    #region Getters and Setters



    #endregion

    #region Constructors

    //Test Constructor

    public Admin() : base()
    {}

    //Constructor for generating Admin classes when loading from databse
    public Admin(
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
    {}

    #endregion

}
