using System;
using System.Buffers.Binary;

class Program
{
    static void Main()
    {
        //There are two data types one is value type and other one is reference type
        //1. Value types
        // 1.1--> Numbers
        //  1.1.1 --->Integers
        byte a = 34; //8 Bit unsigned intiger.Which means upto 11111111 bit or Equivalent to 255 intiger can be hold by byte .so when is it useful? When we have to store person's age it is useful.
        short b = 345; // 16 bit 
        int c = 23232; //
        long d = 3232432431232;

        //  1.1.2 --->Floating Numbers
        float e = 0.4f; //smallest possible floating point
        double f = 234342.3; //by default c# takes floating number in double type .so here we need not to mention as we did in float
        decimal g = 3434234324.43434234m; //if we do not use m suffix it will consider these value as double type and gives error

        // 1.2--> Characters
        char h = 'c';

        // 1.3--> Boolean
        bool i = true;

        //2. Reference types
        string j = "lily_in_the_valley";
        object k = 1212; //you can assign anything in object.
        object l = false;
        object m = "John_doe";
        //aslo the any class names we define is also comes under reference types

    }
}