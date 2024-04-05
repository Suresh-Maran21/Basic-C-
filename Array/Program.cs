using System;
using System.Net.NetworkInformation;
using System.Xml.Serialization;
namespace Array;
class Program{
    public static void Main(string[] args){
        using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int start=int.Parse(Console.ReadLine());
                int differ=int.Parse(Console.ReadLine());
                int end=int.Parse(Console.ReadLine());
                int sum=0;
                int count=0;
                int val=0;
                while(count>=end){
                    val=start+differ;
                    sum=sum+val;
                    start=val;
                    count+=0;
                }
                Console.WriteLine(sum);
            }

        }
            

    }
}
