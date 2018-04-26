using ImplementationStuff.Contracts;

namespace ImplementationStuff.Implementaion.FizzBuzzHandler
{
    public class FizzBuzzHandler : FizzBuzzHandlerBase
    {
        public FizzBuzzHandler(IFizzBuzzHandler nextHandler, IPrintingService printingService) : base(nextHandler, printingService)
        {
        }

        public override bool CanHandle(int number)
        {
            numberToDivide = number;

            return CanFizz() && CanBuzz();
        }

        public override void Print()
        {
            printingService.Print("FizzBuzz");
        }
    }
}
