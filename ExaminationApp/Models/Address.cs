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

    #region Constructors

    //Test Constructor
    public Address()
    {
        this._doorNumber = "1600";
        this._firstAddressLine = "Pennsylvania Avenue";
        this._postCode = "DC 20500";
        this._city = "Washington DC";
    }

    public Address(string doorNumber, string firstAddressLine, string postCode, string city)
    {
        _doorNumber = doorNumber;
        _firstAddressLine = firstAddressLine;
        _postCode = postCode;
        _city = city;
    }


    #endregion
}
