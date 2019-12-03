using System;
using System.Collections.Generic;

namespace IteratorDesignPattern1
{
    public class RadioCollection: IRadioCollection
    {
        private List<FMRadio> radioStationList = new List<FMRadio>();

        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }

        public void AddChannel(FMRadio channel)
        {
            radioStationList.Add(channel);
        }

        public void RemoveChannel(FMRadio channel)
        {
            radioStationList.Remove(channel);
        }

        public int Count => radioStationList.Count;

        public FMRadio this[int index]
        {
            get { return radioStationList[index]; }
            set { radioStationList.Add(value); }
        }
    }
}
