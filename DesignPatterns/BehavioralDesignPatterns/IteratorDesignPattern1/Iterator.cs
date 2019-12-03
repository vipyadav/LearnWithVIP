
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

        public bool IsDone
        {
            get
            {
                if (currentIndex < radioStationList.Count)
                    return false;
                return true;
            }
        }

        public FMRadio First()
        {
            currentIndex = 0;
            return radioStationList[currentIndex];
        }

        public FMRadio Next()
        {
            currentIndex++;
            if (IsDone == false)
                return radioStationList[currentIndex];
            else
                return null;
        }
    }
}
