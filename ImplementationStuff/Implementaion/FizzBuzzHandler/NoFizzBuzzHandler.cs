using ImplementationStuff.Contracts;

namespace ImplementationStuff.Implementaion.FizzBuzzHandler
{
    public class NoFizzBuzzHandler : FizzBuzzHandlerBase
    {
        private int fizzBuzzNumber;

        public NoFizzBuzzHandler(IFizzBuzzHandler nextHandler, IPrintingService printingService) : base(nextHandler, printingService)
        {
        }

        public override bool CanHandle(int number)
        {
            fizzBuzzNumber = number;
            return !CanFizz(number) && !CanBuzz(number);
        }

        public override void Print()
        {
            printingService.Print(fizzBuzzNumber.ToString());
        }
    }
}
