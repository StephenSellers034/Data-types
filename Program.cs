using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types;

class Program
{
    static void Main(string[] args)
    {
        //type name;
        int sampleInt = int.MaxValue; // declaring and intializing variable, also uses more data or space.
        Console.WriteLine(sampleInt);

        long sampleLong = long.MaxValue; // gives more intergers or longer value if max or min
        Console.WriteLine(sampleLong); // displays value

        short sampleShort = short.MinValue;
        Console.WriteLine(sampleShort);

        double sampleDouble = 5.5;// can use max or min value with double also anything after E in max value is times power of 10
        Console.WriteLine(sampleDouble);

        bool sampleBool = true;// can only be true or false
        Console.WriteLine(sampleBool);

        char sampleChar = 'a'; // can only be one character, important only can be used with single Ticks ''
        Console.WriteLine(sampleChar);

        string sampleString = "I Love my Wife"; // strings need double quotaions to work wont work with single ticks.
        Console.WriteLine(sampleString);

        Console.WriteLine("Hello, World!");// case sensitive when writing wont work if first char is not capital needs par to encapsulate data to be displayed.
    }
}

