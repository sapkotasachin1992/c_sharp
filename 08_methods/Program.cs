using System;
class MethodTeacher
{
    static void Main()
    {
        MethodTeacher method = new MethodTeacher();
        double newResult = method.Sum(1, 2);
        Console.WriteLine(newResult);

        Console.WriteLine("How many numbers to proceed?");
        int totalNums = int.Parse(Console.ReadLine());
        Console.WriteLine($"Enter {totalNums} numbers");
        int[] nums = new int[totalNums];
        for (int i = 0; i < totalNums; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            nums[i] = temp;

        }

        int resultofsum = method.SumOfEven(nums);
        Console.WriteLine("sum is " + resultofsum);


        //min and max
        int[] newNums = { 12, 43, 33, 15, 32, 54 };
        // (int, int) minmaxresult = method.MinMax(newNums);
        // Console.WriteLine($"min value is {minmaxresult.Item1} and maximum value is {minmaxresult.Item2}");
        //here is more better approach to print multple returned value
        (int min, int max) minmaxresult = method.MinMax(newNums);
        Console.WriteLine($"min value is {minmaxresult.min} and maximum value is {minmaxresult.max}");

        //named arguments
        method.PrintDetails(age: 32, name: "sachin", address: "nuwakot");

    }
    internal int SumOfEven(int[] nums)
    {

        int sum = 0;
        foreach (int num in nums)
        {
            if (num % 2 == 0)
            {
                sum = sum + num;
            }
        }
        return sum;
    }
    public double Sum(double num1, double num2)
    {
        return num1 + num2;
    }
    //defining a method that receives n number of parameter and performs operation
    public double Sum(params double[] numbers)//after using params you can pass arguments in comma form oterwise you need to pass array of input in absence of params
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    //returning multiple values
    //method to find min and max value from array

    (int, int) MinMax(int[] numbers)
    {
        int large = 0;
        int small = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > large)
            {
                large = numbers[i];
            }

            if (numbers[i] < small)
            {
                small = numbers[i];
            }
        }

        return (small, large);

    }

    //Named argument-->after using this you dont have to pass argument in order. you can pass as you want
    void PrintDetails(string name, byte age, string address)
    {
        Console.WriteLine($"Name:{name}[{age}], Address:{address}");

    }

}