using System;
using System.Xml.XPath;
namespace DoWhileLoop;
class Program{
    public static void Main(string[] args){
        string result="";
        do
        {
        Console.Write("Enter a number: ");
        int number=int.Parse(Console.ReadLine());
        if(number % 2==0){
            Console.WriteLine("Even");
            }else{
                Console.WriteLine("Odd");
            }
        Console.WriteLine("Process with another number say yes/no: ");
        result=Console.ReadLine();
        if(result!="yes" && result!="no"){
            Console.WriteLine("you are entered a wrong input: ");
            result=Console.ReadLine();
        }
        }while(result =="yes");
    }
}
