using System;

namespace Fourth
{
    class BmwCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving into the bus stop");
        }

        public void Park()
        {
            Console.WriteLine("Parking on as many parking spots as possible at the same time");
        }
    }
}