using ImplementationStuff.Contracts;

namespace ImplementationStuff.Implementaion.FizzBuzzHandler
{
    public abstract class FizzBuzzHandlerBase : IFizzBuzzHandler
    {
        private IFizzBuzzHandler nextHandler;
        protected IPrintingService printingService;
        protected int numberToDivide = 0;

        public FizzBuzzHandlerBase(IFizzBuzzHandler nextHandler, IPrintingService printingService)
        {
            this.nextHandler = nextHandler;
            this.printingService = printingService;
        }

        public abstract bool CanHandle(int number);
        public abstract void Print();
        public void Handle(int numberToHandle)
        {
            if (CanHandle(numberToHandle))
            {
                Print();
            }
            else
            {
                if (this.nextHandler != null)
                {
                    nextHandler.Handle(numberToHandle);
                }
            }
        }
    }
}
