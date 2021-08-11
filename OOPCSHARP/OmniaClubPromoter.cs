using System;
using System.Collections.Generic;
using System.Text;

public class OmniaClubPromoter : Promoter
{
    public OmniaClubPromoter(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
    {

    }

    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine("I share with my friend.");
    }

    protected override void UsePaidAds()
    {
        Console.WriteLine("I use google AdWords.");
    }
}


