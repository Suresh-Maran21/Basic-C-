using System;
namespace MethodAssignment;
class Program{
            public static void Main(string[] args)
            {
                int n1=int.Parse(Console.ReadLine());
                int n2=int.Parse(Console.ReadLine());
                char c=char.Parse(Console.ReadLine());
                switch(c){
                    case '+':
                    {
                        int result=Addition(n1,n2);
                        Console.WriteLine(result);
                        break;
                    }
                    case '-':
                    {
                        int result=Subtraction(n1,n2);
                        Console.WriteLine(result);
                        break;
                    }
                    case '*':
                    {
                        int result=Multiplication(n1,n2);
                        Console.WriteLine(result);
                        break;
                    }
                    case '/':
                    {
                        int result=Division(n1,n2);
                        Console.WriteLine(result);
                        break;
                    }
                    default :
                    {
                        break;
                    }
                }
            }
            static int Addition(int a,int b){
                int final=a+b;
                return final;
            }
            static int Subtraction(int a,int b){
                int final=a-b;
                return final;
            }
            static int Multiplication(int a,int b){
                int final=a*b;
                return final;
            }
            static int Division(int a,int b){
                int final=a/b;
                return final;
            }
}
