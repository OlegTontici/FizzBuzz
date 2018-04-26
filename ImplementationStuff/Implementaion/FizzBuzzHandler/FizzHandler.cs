using ImplementationStuff.Contracts;

namespace ImplementationStuff.Implementaion.FizzBuzzHandler
{
    public class FizzHandler : FizzBuzzHandlerBase
    {
        public FizzHandler(IFizzBuzzHandler nextHandler, IPrintingService printingService) : base(nextHandler, printingService)
        {
        }

        public override bool CanHandle(int number)
        {
            numberToDivide = number;

            return numberToDivide % 3 == 0;
        }

        public override void Print()
        {
            printingService.Print("Fizz");
        }
    }
}
