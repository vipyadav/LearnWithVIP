using System;

namespace StateDesignPattern_CarChangingGears
{
    public class FirstGear : IGearState
    {
        private int gearNumber;

        public override string ToString()
        {
            return "Car is in " + gearNumber + " gear.";
        }

        public void ChangeGear()
        {
            gearNumber = 1;
        }

        public void Accelarate(int speed)
        {
            if (speed > 20)
               Console.WriteLine("Can not be accelarated to " + speed + " kmph in gear 1");
            else
                Console.WriteLine("Car is running at " + speed + " kmph in gear 1");
        }
    }
}
