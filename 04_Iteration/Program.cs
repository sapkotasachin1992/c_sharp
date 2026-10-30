using System;

class Program
{

    static void Main()
    {
        Program ss = new Program();
        ss.IterationStatement();
    }

    void IterationStatement()
    {
        //first of all for loop
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Sachin is my Name");
        }

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
        //foreach loop
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }

        //while loop
        // while (true)
        // {
        //     Console.WriteLine("infinite loop");
        // }

        string[] container = new string[10];
        byte index = 0;
        byte remainingSpace = 10;
        while (true)
        {
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1.Add new video");
            Console.WriteLine("2.List all videos");
            Console.WriteLine("3.Update video");
            Console.WriteLine("4.Delete video");
            Console.WriteLine("5.Exit");
            byte choice = byte.Parse(Console.ReadLine());

            if (choice == 1)
            {
                if (remainingSpace == 0)
                {
                    Console.WriteLine("You are out of space first delete videos");

                }
                else
                {
                    Console.WriteLine("Enter the title ");
                    string title = Console.ReadLine();
                    container[index] = title;
                    index++;
                    remainingSpace--;
                }



            }
            else if (choice == 2)
            {
                if (container.Length == 0)
                {
                    Console.WriteLine("No video added yet!!");

                }
                else
                {
                    for (int i = 0; i < container.Length; i++)
                    {
                        Console.WriteLine(i + 1 + " " + container[i]);
                    }
                }

            }

            else if (choice == 5)
            {
                break;
            }

        }
    }
}