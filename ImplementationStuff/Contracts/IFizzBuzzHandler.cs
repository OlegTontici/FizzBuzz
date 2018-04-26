namespace ImplementationStuff.Contracts
{
    public interface IFizzBuzzHandler 
    {
        void Handle(int numberToHandle);
        bool CanHandle(int number);
        void Print();
    }
}
