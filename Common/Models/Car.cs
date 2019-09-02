using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car: IComparable
    {
        private int year;
        private string make;

        public Car(string Make, int Year)
        {
            make = Make;
            year = Year;
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }


        #region IComparer

        // Nested class to do ascending sort on year property.
        private class SortByYearAscending : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Car c1 = (Car)a;
                Car c2 = (Car)b;

                if (c1.year > c2.year)
                    return 1;

                if (c1.year < c2.year)
                    return -1;
                else
                    return 0;
            }
        }

        // Nested class to do descending sort on year property.
        private class SortByYearDescending : IComparer<Car>
        {
            int IComparer<Car>.Compare(Car c1, Car c2)
            {
                if (c1.year < c2.year)
                    return 1;

                if (c1.year > c2.year)
                    return -1;

                else
                    return 0;
            }
        }

        // Nested class to do descending sort on make property.
        private class SortByMakeDescending : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Car c1 = (Car)a;
                Car c2 = (Car)b;
                return string.Compare(c2.make, c1.make);
            }
        }

        #endregion

        // Implement IComparable CompareTo to provide default sort order.
        int IComparable.CompareTo(object obj)
        {
            Car c = (Car)obj;
            return string.Compare(this.make, c.make);
        }

        // Method to return IComparer object for sort helper.
        public static IComparer SortYearAscending()
        {
            return new SortByYearAscending();
        }

        // Method to return IComparer object for sort helper.
        public static IComparer<Car> SortYearDescending()
        {
            return new SortByYearDescending();
        }

        // Method to return IComparer object for sort helper.
        public static IComparer SortMakeDescending()
        {
            return new SortByMakeDescending();
        }
    }
}
