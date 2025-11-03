using System;

class Program
{
    static void Main()
    {

        int[] favoriteNumbers = { 7, 42, 13, 99, 5 };


        Array.Sort(favoriteNumbers);


        Array.Reverse(favoriteNumbers);


        Console.WriteLine("Array elements:");
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }
        
        int numberToFind = 42;
        int position = Array.IndexOf(favoriteNumbers, numberToFind);

        if (position != -1)
        {
            Console.WriteLine($"\nThe number {numberToFind} is at index {position}.");
        }
        else
        {
            Console.WriteLine($"\nThe number {numberToFind} is not in the array.");
        }
    }
}