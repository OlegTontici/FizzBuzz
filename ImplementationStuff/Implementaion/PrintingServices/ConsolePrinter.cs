using ImplementationStuff.Contracts;
using System;

namespace ImplementationStuff.Implementaion.PrintingServices
{
    public class ConsolePrinter : IPrintingService
    {
        public void Print(string valueToPrint)
        {
            Console.Write(valueToPrint);
        }

        public void PrintNewLine()
        {
            Console.Write(Environment.NewLine);
        }
    }
}
