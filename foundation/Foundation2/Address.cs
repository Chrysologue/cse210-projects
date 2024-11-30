using System;
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsInUSA()
    {
        bool result = (_country.ToUpper() == "USA") ? true : false;
        return result;
    }
    public string GetInfo()
    {
        return $"Street: {_street}\nCity: {_city}\nState: {_state}\nCountry: {_country}";
    }
}