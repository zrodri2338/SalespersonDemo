using System;

public class GirlScout : Salesperson
{
    private int boxesSold = 0;

    public int BoxesSold
    {
        get { return boxesSold; }
        set { boxesSold = value; }
    }

    public GirlScout(string firstName, string lastName)
        : base(firstName, lastName)
    {
    }

    public void SellCookies(int boxes)
    {
        boxesSold += boxes;
    }
}