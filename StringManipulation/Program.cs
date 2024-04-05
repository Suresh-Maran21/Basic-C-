using System;
using System.Reflection.Metadata;
using System.Threading;
namespace StringManipulation;
class Program{
    public static void Main(string[] args){
        Console.Write("Enter a longString: ");
        string longString=Console.ReadLine();
        Console.Write("Enter a subString: ");
        string subString=Console.ReadLine();
        string[] arr=longString.Split(subString); 
        int count=0;     
        foreach(string i in arr){
            count++;
        }
        Console.WriteLine(count-1);

    }
}
