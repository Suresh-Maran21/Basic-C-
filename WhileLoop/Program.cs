using System;
namespace WhileLoop;
class Program{
    public static void Main(string[] args){
        int start=0;
        while(start<25){
            if(start%2==0){
                Console.WriteLine(start);
            }
            start++;
        } 

        Console.Write("Enter a number: ");
        bool isValid=int.TryParse(Console.ReadLine(),out int output);
        while(!isValid)
        {
            Console.Write("Invalid Number.Enter again: ");
            isValid=int.TryParse(Console.ReadLine(),out output);

        }


    }
}

