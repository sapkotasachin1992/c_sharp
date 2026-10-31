

public class Country
{

    string name;
    readonly int AREA;
    //Default Constructor
    public Country()
    {
        Console.WriteLine("constructor called");
    }

    //parametarized constructor
    public Country(string name, int area)
    {
        this.name = name;
        AREA = area;//as AREA is readonly it can be only initialized inside constructor and it is assigned in runtime . note:readonly is also const but applied in runtime whereas const is applied in compile time

    }
    internal void PrintName()
    {
        Console.Write("i am sachin");
    }
}

class Program
{
    static void Main()
    {
        Country c = new Country();
        c.PrintName();

    }
}