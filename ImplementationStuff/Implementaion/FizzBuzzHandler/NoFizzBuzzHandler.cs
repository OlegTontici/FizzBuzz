using ImplementationStuff.Contracts;

namespace ImplementationStuff.Implementaion.FizzBuzzHandler
{
    public class NoFizzBuzzHandler : FizzBuzzHandlerBase
    {
        public NoFizzBuzzHandler(IFizzBuzzHandler nextHandler, IPrintingService printingService) : base(nextHandler, printingService)
        {
        }
        public override bool CanHandle(int number)
        {
            numberToDivide = number;

            return !CanFizz() && !CanBuzz();
        }

        public override void Print()
        {
            printingService.Print(numberToDivide.ToString());
        }
    }
}
