using ParkingLotApp.Interfaces;
using ParkingLotApp.Models;
using System;

namespace ParkingLotApp.Models.ParkingStrategy
{
    public class ShortestDistanceParkingStrategy : IParkingStartegy
    {
        public ParkingSpotInfo FindParkingSpot(IVehicle vehicle)
        {
            Console.WriteLine("Finding ShortestDistance Parking Spot");
            return new ParkingSpotInfo(Guid.NewGuid().ToString());
        }
    }
}
