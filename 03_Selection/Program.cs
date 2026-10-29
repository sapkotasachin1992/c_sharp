using System;

class Program
{
    static void Main()
    {
        Program ss = new Program();
        // ss.SelectionStatement();
        ss.LearnSwitch();
    }

    void SelectionStatement()
    {

        //we will be learning about selection statements
        //if else
        byte x = byte.Parse(Console.ReadLine());
        // byte x = 10;


        string result = x == 10 ? "same number" : "different number";
        Console.WriteLine(result);

        Console.WriteLine("Enter your age");
        string input = Console.ReadLine();
        byte y = byte.Parse(input);

        if (y <= 18)
        {
            Console.WriteLine("You are not eligible to vote");
        }
        else
        {
            Console.WriteLine("You are eligible to vote");
        }

    }


    void LearnSwitch()
    {
        Console.WriteLine("Enter your choice");
        byte choice = byte.Parse(Console.ReadLine());
        string result = "sunday";
        switch (choice)
        {
            case 1:
                result = "sunday";
                break;
            case 2:
                result = "monday";
                break;
            case 3:
                result = "Tuesday";
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }

        Console.WriteLine("Today is " + " " + result);


    }
}