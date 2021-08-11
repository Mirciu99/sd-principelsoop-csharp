using System;
using System.Collections.Generic;
using System.Text;

public class BookWriter : Writer, IVlogger
{
    public BookWriter(string firstName, string lastName) : base(firstName, lastName)
    {

    }
  


    public override void Vlog()
    {
        Console.WriteLine("I vlog using my Iphone");
    }

    public override void Write()
    {
        Console.WriteLine("I write for my own book.");
    }
}