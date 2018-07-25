// Language: C#
// Runtime: .Net Core 2.1
// Platform: Cross-platform(Windows, Mac OS, Linux) 

using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assuming P1, D1 and D2 to be positive integers 
            // and greater than zero
            Console.WriteLine("Enter P1:");
            int P1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter D1:");
            int D1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter D2:");
            int D2=Convert.ToInt32(Console.ReadLine());

            if(P1%D1==0 || P1%D2==0){
                var multiple1=P1/D1;
                var multiple2=P1/D2;
                if(multiple1%2==0 && multiple2%2==0){
                    Console.WriteLine("FizzBuzz");
                } 
                else if(multiple1%2==0){
                    Console.WriteLine("Fizz");
                }
                else if(multiple2%2==0){
                    Console.WriteLine("Buzz");
                }
                else{
                    for(int i=1;i<=P1;i++){
                    Console.WriteLine(i);
                    }
                }
            }       
            else {
                for(int i=1;i<=P1;i++){
                 Console.WriteLine(i);
                }
            }
        }
    }
}
