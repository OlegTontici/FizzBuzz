﻿using ImplementationStuff.Contracts;

namespace ImplementationStuff.Implementaion.FizzBuzzHandler
{
    public abstract class FizzBuzzHandlerBase : IFizzBuzzHandler
    {
        private IFizzBuzzHandler nextHandler;
        protected IPrintingService printingService;

        public FizzBuzzHandlerBase(IFizzBuzzHandler nextHandler, IPrintingService printingService)
        {
            this.nextHandler = nextHandler;
            this.printingService = printingService;
        }

        public abstract void Print();
        public abstract bool CanHandle(int number);
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

        protected bool CanFizz(int number)
        {
            return number % 3 == 0;
        }

        protected bool CanBuzz(int number)
        {
            return number % 5 == 0;
        }
    }
}
