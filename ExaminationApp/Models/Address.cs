namespace ExaminationApp.Models;

internal struct Address
{
    #region Attributes

    private string _doorNumber;
    private string _firstAddressLine;
    private string _postCode;
    private string _city;

    #endregion


    #region Getters and Setters

    public string DoorNumber
    {
        get { return this._doorNumber; }
        set { this._doorNumber = value; }
    }

    public string FirstAddressLine
    {
        get { return this._firstAddressLine; }
        set { this._firstAddressLine = value;}
    }

    public string PostCode
    {
        get { return this._postCode; }
        set { this._postCode = value; }
    }

    public string City
    {
        get { return this._city; }
        set { this._city = value; }
    }

    #endregion
}
