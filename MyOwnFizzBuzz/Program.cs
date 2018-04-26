using System;

namespace MyOwnFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzer myFizzBuzzer = new FizzBuzzer();
            myFizzBuzzer.FizzBuzz(100);
            Console.ReadLine();
        }
    }
}
