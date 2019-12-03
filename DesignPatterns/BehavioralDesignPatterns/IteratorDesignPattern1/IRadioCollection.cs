
namespace IteratorDesignPattern1
{
    // Also can call IAggregate
    public interface IRadioCollection
    {
        void AddChannel(FMRadio channel);

        void RemoveChannel(FMRadio channel);

        IIterator CreateIterator();
        FMRadio this[int itemIndex] { set; get; }
        int Count { get; }
    }
}
