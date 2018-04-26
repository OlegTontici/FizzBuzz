using ImplementationStuff.Contracts;

namespace ImplementationStuff.Implementaion.FizzBuzzHandler
{
    public class BuzzHandler : FizzBuzzHandlerBase
    {
        public BuzzHandler(IFizzBuzzHandler nextHandler, IPrintingService printingService) : base(nextHandler, printingService)
        {
        }

        public override bool CanHandle(int number)
        {
            numberToDivide = number;

            return CanBuzz();
        }

        public override void Print()
        {
           printingService.Print("Buzz");
        }
    }
}
