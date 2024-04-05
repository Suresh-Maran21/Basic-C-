using System;
namespace SwitchCase;
class Program{
    public static void Main(string[] args){
        Console.Write("Enter a Number1: ");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Enter a Number2: ");
        int number2=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a operator: ");
        char sign=char.Parse(Console.ReadLine());
        switch(sign){
            case '+':
            {
                Console.WriteLine(number1+number2);
                break;
            }
            case '-':
            {
                Console.WriteLine(number1-number2);
                break;
            }
            case '*':
            {
                Console.WriteLine(number1*number2);
                break;
            }
            case '/':
            {
                Console.WriteLine(number1/number2);
                break;
            }
            case '%':
            {
                Console.WriteLine(number1%number2);
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Operator");
                break;
            }
        }
        


    }
}