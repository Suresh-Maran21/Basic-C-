using System;
namespace DateTimeAssignment;
class Program{
    public static void Main(string[] args){
        DateTime dob = new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(dob.Year);
        Console.WriteLine(dob.Month);
        Console.WriteLine(dob.Day);
        Console.WriteLine(dob.ToString("hh"));
        Console.WriteLine(dob.ToString("MM"));
        Console.WriteLine(dob.ToString("ss"));
        Console.WriteLine(dob.ToShortDateString());
        Console.WriteLine(dob.ToString("dd/mm/yyyy hh:MM:ss tt"));
        Console.WriteLine(dob.ToString("tt ss:mm:hh yyyy/MM/dd"));
        Console.Write("DateTime:(yyyy/MM/dd hh:mm:ss tt):");
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        Console.WriteLine(date);




    } 
}

