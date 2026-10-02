using System;

class Program
{
    static void Main()
    {
        Program ss = new Program();
        ss.SelectionStatement();
    }

    void SelectionStatement()
    {

        //we will be learning about selection statements
        //if else
        byte x = 10;


        string result = x == 10 ? "same number" : "different number";
        Console.WriteLine(result);


        byte y = Console.ReadLine();

        if (y <= 18)
        {
            Console.WriteLine("You are not eligible to vote");
        }
        else
        {
            Console.WriteLine("You are eligible to vote");
        }

        if (true)
        {
            Console.WriteLine("Streak maintained")
        }
    }
}