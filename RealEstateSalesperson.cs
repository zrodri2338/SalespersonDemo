using System;

public class RealEstateSalesperson : Salesperson
{
    private double totalValueSold = 0;
    private double totalCommissionEarned = 0;
    private double commissionRate;

    public double TotalValueSold
    {
        get { return totalValueSold; }
        set { totalValueSold = value; }
    }

    public double TotalCommissionEarned
    {
        get { return totalCommissionEarned; }
        set { totalCommissionEarned = value; }
    }

    public double CommissionRate
    {
        get { return commissionRate; }
        set { commissionRate = value; }
    }

    public RealEstateSalesperson(
        string firstName,
        string lastName,
        double commissionRate)
        : base(firstName, lastName)
    {
        this.commissionRate = commissionRate;
    }

    public void SellHouse(double value)
    {
        totalValueSold += value;
        totalCommissionEarned += value * commissionRate;
    }
}