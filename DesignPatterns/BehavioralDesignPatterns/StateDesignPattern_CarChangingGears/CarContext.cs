using System;

namespace StateDesignPattern_CarChangingGears
{
    public class CarContext : IGearState
    {
        public IGearState Gear { get; set; }

        public void Accelarate(int speed)
        {
            if (null == Gear)
                Console.WriteLine("Car can not be accelarated as its in Neutral");
            else
                Gear.Accelarate(speed);
        }

        public void ChangeGear()
        {
            Gear.ChangeGear();
        }

        public override string ToString()
        {
            return Gear.ToString(); 
        }
    }
}
