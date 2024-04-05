using System;
using System.Data;
namespace TypeConverson;

class Program{
    public static void Main(string[] arg){
        Console.Write("Enter your name: ");
        string name=Console.ReadLine();
        Console.Write("Enter age: ");
        int age=int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject1: ");
        double mark1=double.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2: ");
        double mark2=double.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject3: ");
        double mark3=double.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char grade=Convert.ToChar(Console.ReadLine());
        Console.Write("Enter mobile number: ");
        long mobileNumber=Convert.ToInt64(Console.ReadLine());
        Console.Write("Enter Mail id: ");
        string mailId=Console.ReadLine();
        

        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Mobile: "+mobileNumber);
        Console.WriteLine("Marks1: "+mark1);
        Console.WriteLine("Marks2: "+mark2);
        Console.WriteLine("Marks3: "+mark3);
        Console.WriteLine("Total: "+(mark1+mark2+mark3));
        Console.WriteLine("Average: "+((mark1+mark2+mark3)/3));
        Console.WriteLine("Grade: "+grade);
        Console.WriteLine("Mail id: "+mailId);



    
    }
}
