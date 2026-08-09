using System;

public class Salesperson
{
    private string firstName;
    private string lastName;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public Salesperson(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string GetFullName()
    {
        return firstName + " " + lastName;
    }
}