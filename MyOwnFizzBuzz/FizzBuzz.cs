using ImplementationStuff.Contracts;
using ImplementationStuff.Implementaion.FizzBuzzHandler;
using ImplementationStuff.Implementaion.PrintingServices;

namespace MyOwnFizzBuzz
{
    public class FizzBuzzer
    {
        private IFizzBuzzHandler buzzHandler;
        private IFizzBuzzHandler fizzHandler;
        private IFizzBuzzHandler fizzBuzzHandler;
        private IFizzBuzzHandler noFizzBuzzHandler;
        private IPrintingService printingService;

        public FizzBuzzer()
        {
            printingService = new ConsolePrinter();
            noFizzBuzzHandler = new NoFizzBuzzHandler(null, printingService);
            buzzHandler = new BuzzHandler(noFizzBuzzHandler, printingService);
            fizzHandler = new FizzHandler(buzzHandler, printingService);
            fizzBuzzHandler = new FizzBuzzHandler(fizzHandler, printingService); 
        }

        public void FizzBuzz(int amountOfTimesToTryFizzBuzz)
        {
            for (int i = 1; i <= amountOfTimesToTryFizzBuzz; i++)
            {
                fizzBuzzHandler.Handle(i);
                printingService.PrintNewLine();
            }
        }
    }
}
