namespace IteratorDesignPattern1
{
    public interface IIterator
    {
        FMRadio First();
        FMRadio Next();
        FMRadio Current { get; }
        bool IsDone { get; }
    }
}
