using System;

class Program
{
    static void Main()
    {

        DateTime birthDate = new DateTime(2002, 5, 15); 


        DateTime currentDate = DateTime.Now;


        TimeSpan ageSpan = currentDate - birthDate;


        int ageInYears = (int)(ageSpan.TotalDays / 365.25);

        
        Console.WriteLine("Birthdate: " + birthDate.ToShortDateString());
        Console.WriteLine("Current Date: " + currentDate.ToShortDateString());
        Console.WriteLine("Age: " + ageInYears + " years");


        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine("Birthdate + 10 days: " + newDate.ToShortDateString());
    }
}