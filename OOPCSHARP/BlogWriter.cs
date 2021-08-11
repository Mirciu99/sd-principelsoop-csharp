﻿using System;
using System.Collections.Generic;
using System.Text;

public class BlogWriter : Writer
{
    public BlogWriter(string firstName, string lastName) : base(firstName, lastName)
    {

    }

    public override void Vlog()
    {
        Console.WriteLine("I vlog using my GoPro");
    }

    public override void Write()
    {
        Console.WriteLine("I write for my own blog.");
    }
}