using System;

namespace StateDesignPattern_CarChangingGears
{
    class Program
    {
        static void Main(string[] args)
        {
            CarContext car = new CarContext();

            car.Accelarate(18);

            car.Gear = new FirstGear();
            car.ChangeGear();

            Console.WriteLine(car);

            car.Accelarate(30);
            car.Accelarate(18);

            car.Gear = new SecondGear();
            car.ChangeGear();

            Console.WriteLine(car);
            car.Accelarate(35);

            Console.ReadKey();
        }
    }
}
