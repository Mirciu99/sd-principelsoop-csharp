using System;
using System.Collections.Generic;
using System.Text;

public class XSClubPromoter : Promoter, IBodyBuilder, IVlogger
{
    public XSClubPromoter(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
    {

    }

    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine("I share with my instagram followers.");
    }

    protected override void UsePaidAds()
    {
        Console.WriteLine("I use Facebook Ads.");
    }


    public void Vlog()
    {
        Console.WriteLine("I use a DSLR in order to vlog.");
    }
    public void Workout()
    {
        Console.WriteLine("I workout at my house.");
    }


}