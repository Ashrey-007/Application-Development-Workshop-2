using System;

class Program
{
    static void Main(string[] args)
    {
        byte myByte = 255;
        short myShort = 32000;
        int myInt = 42;
        long myLong = 1234567890L;
        float myFloat = 3.14f;
        double myDouble = 3.14159;
        decimal myDecimal = 100.5m;
        char myChar = 'A';
        bool myBool = true;
        
        string intToString = myInt.ToString();
        
        string piString = "3.14";
        double stringToDouble = Convert.ToDouble(piString);
        
        Console.WriteLine($"byte: {myByte}");
        Console.WriteLine($"short: {myShort}");
        Console.WriteLine($"int: {myInt}");
        Console.WriteLine($"long: {myLong}");
        Console.WriteLine($"float: {myFloat}");
        Console.WriteLine($"double: {myDouble}");
        Console.WriteLine($"decimal: {myDecimal}");
        Console.WriteLine($"char: {myChar}");
        Console.WriteLine($"bool: {myBool}");
        Console.WriteLine($"Integer to string: {intToString}");
        Console.WriteLine($"String to double: {stringToDouble}");
    }
}