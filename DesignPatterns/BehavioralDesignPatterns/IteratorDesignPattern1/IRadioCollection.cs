
namespace IteratorDesignPattern1
{
    // Also can call IAggregate
    public interface IRadioCollection
    {
        void AddChannel(FMRadio c);

        void RemoveChannel(FMRadio c);

        IIterator CreateIterator();
        FMRadio this[int itemIndex] { set; get; }
        int Count { get; }
    }
}
