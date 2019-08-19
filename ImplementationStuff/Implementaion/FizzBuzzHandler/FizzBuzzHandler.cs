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
            return CanFizz(number) && CanBuzz(number);
        }

        public override void Print()
        {
            printingService.Print("FizzBuzz");
        }
    }
}
