

public class Country
{

    //definining static porperties or members .
    public static readonly bool isOnEarth;//this is same for all objects that will be created for this class .we make readonly so that  we can assign only through constructor(static constructor) and it cannot be changed while calling 
    string name;
    readonly int AREA;
    // 1.Instance constructor
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

    //2.static constructor
    //-->Static constructor is executed only once no matter how many object is created and run.and static constructor runs first then that of  instance constructor.
    //note:static means it is same for any number of objects.so when we try to access those property we call it directly through class name
    static Country()
    {
        //as it runs only once during whole lifecycle of class. here we initialized those resources that is common for every object .
        isOnEarth = true;
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
        var x = Country.isOnEarth;

        c.PrintName();

    }
}