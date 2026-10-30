using System;
internal class Person
{
    //note:The properties we are learning here is not the below properties that is defined inside class.To understand this see below where it is described as well as used.
    private byte age;
    int grade;
    public string name;
    DateTime dob;
    //getter setter
    //so properties is actually used here . like we know we can assign any value in person.age but what we want is we only assign age when the value is between 30 and 40 .in this scenario properties used.
    public byte Age //now while we use this Age to get value of age which is actually private
    {
        get { return age; }
        set
        {
            if (value > 30 && value < 40) // value is keyword which receives the value enter by use in Age.
            {
                age = value;
            }
        }
    }

    //auto implemented properties
    public string Address { get; set; }

    //read only properties
    public string Surname { get; }


}