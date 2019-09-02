using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car
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
    }
}
