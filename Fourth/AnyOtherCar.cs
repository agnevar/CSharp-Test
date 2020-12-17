using System;

namespace Fourth
{
    class AnyOtherCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving to the destination");
        }

        public void Park()
        {
            Console.WriteLine("Parking on a single parking spot");
        }
    }
}