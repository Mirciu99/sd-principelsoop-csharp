using System;
using System.Collections.Generic;
using System.Text;

public abstract class Writer: IVlogger
{
    private string firstName;
    private string lastName;


    public Writer(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string AuthorBio
    {
        get
        {
            return string.Format("My name is {0} {1}", this.firstName, this.lastName);
        }
    }

    public abstract void Write(); //will be defined by the child classes 

    public abstract void Vlog();

}