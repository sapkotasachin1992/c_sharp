

public abstract class Shape //if we are creating abstract methods and members in a class then we must assing the class also abstract.Now after using abstract keyword in class we can not create new instance or object of that class too and it also makes sense as the object that will inherit abstract class will create object of itself
{
    public abstract double GetArea(); //abstract call implementatin is different for diffrent object that it derives so we do not write implementation here.
    //Note:Derived class must use the abstract methods  if it inherit this class,other wise error will be shown
    public abstract double GetCircumference();

    public virtual void PrintResult() // if we have same method name PrintResult() in derived class now using virtual keyword allows to use override keyword in base class and you can define same name method there
    {
        Console.WriteLine("Printing result for some shape...");
    }
}



public class Rectangle : Shape  //single Inheritance
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Rectangle(double l, double b)
    {
        this.Length = l;
        this.Breadth = b;
    }

    public override double GetArea() => Length * Breadth;
    public override double GetCircumference() => 2 * (Length + Breadth);

    public override void PrintResult() //we are able to override the method from base class as we use virtual keyword in base class
    {
        // base.PrintResult(); //now this will print the result of base class
        Console.WriteLine("Printing result for rectangle...");
        Console.WriteLine($"Area:{this.GetArea()}");

    }
}

public class Square : Rectangle //multi level inheritance
{

    //instead of inherit with shape class we inherit from reactangle which decreases our code length and computational cost
    // public Square(double length)
    // {
    //     // base.Length = length;
    //     // base.Breadth = length;
    // }

    //this is later on modifed version as when we create constructor of rectangle for itself then we inherit directly base and base means always constructor of main parent .so we directly pass value in constructor of parent
    public Square(double length) : base(length, length) { }


}

//note: c# doesnot support multiple inheritance of classes instead it supports multiple implementation of interface

// eg 
interface A
{ }
interface B
{ }
//interface is used when same behaviour is shared among multiple class and interface is written in parallel to class
class D : A, B
{
    //this is possible 
}

interface IDiagonalComputable
{
    //it is similar to abstract class we do not write implementation here

    public double GetDiagonal(); //now you can use implement or inherit this interface and use  this method directly without using override keyword we did in abstract class 
}

