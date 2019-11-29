using System;

namespace StateDesignPattern_CarChangingGears
{
    public class SecondGear : IGearState
    {
        private int gearNumber;

        public override string ToString()
        {
            String str = "Car is in " + gearNumber + " gear.";
            return str;
        }

        public void ChangeGear()
        {
            gearNumber = 2;
        }

        public void Accelarate(int speed)
        {
            if (speed > 40)
               Console.WriteLine("Can not be accelarated to " + speed + " kmph in gear 2");
            else
                Console.WriteLine("Car is running at " + speed + " kmph in gear 2");
        }
    }
}
