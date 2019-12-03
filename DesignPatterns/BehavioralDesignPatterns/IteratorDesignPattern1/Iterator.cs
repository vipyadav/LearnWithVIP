
namespace IteratorDesignPattern1
{
    public class Iterator : IIterator
    {
        private RadioCollection radioStationList = new RadioCollection();
        int currentIndex = 0;

        public Iterator(RadioCollection itemsList)
        {
            radioStationList = itemsList;
        }

        public FMRadio Current => radioStationList[currentIndex];
        public bool IsDone => !(currentIndex < radioStationList.Count);

        public FMRadio First()
        {
            currentIndex = 0;
            return radioStationList[currentIndex];
        }

        public FMRadio Next()
        {
            currentIndex++;
            return (IsDone == false) ? radioStationList[currentIndex] : null;
        }
    }
}
