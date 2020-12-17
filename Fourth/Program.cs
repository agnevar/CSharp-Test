using System;

namespace Fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle bmw = new BmwCar();
            IVehicle otherCar = new AnyOtherCar();

            bmw.Drive();
            bmw.Park();
            otherCar.Drive();
            otherCar.Park();
        }
    }
}
