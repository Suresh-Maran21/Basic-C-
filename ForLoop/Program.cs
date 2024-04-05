using System;
namespace ForLoop;

class Program{
    public static void Main(string[] args){
        Console.Write("Enter a Number1: ");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Enter a Number2: ");
        int number2=int.Parse(Console.ReadLine());
        int sum=0;
        for(int i=number1;i<number2;i++){
            int square=i*i;
            sum=sum+square;

        }Console.WriteLine(sum);
            
    }
}