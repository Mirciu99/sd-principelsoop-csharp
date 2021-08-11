using System;
using System.Collections.Generic;
using System.Text;

public abstract class Promoter
{

    private string firstName;
    private string lastName;
    private long cellPhone;

    public string MyBusinessCard
    {
        get
        {
            return string.Format("{0} {1} {2}", this.firstName, this.lastName, this.cellPhone);
        }
    }



    public Promoter(string firstName, string lastName, long cellPhone)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.cellPhone = cellPhone;
    }

    public void Promote()
    {
        this.ShareWithInnerCircle();
        this.UsePaidAds();
    }

    protected abstract void ShareWithInnerCircle();

    protected abstract void UsePaidAds();

}