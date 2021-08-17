using ParkingLotApp.Interfaces;
using ParkingLotApp.Models;
using System;

namespace ParkingLotApp.Models.ParkingStrategy
{
    public class NearestToExitParkingStrategy : IParkingStartegy
    {
        public ParkingSpotInfo FindParkingSpot(IVehicle vehicle)
        {
            Console.WriteLine("Finding NearestToExit Parking Spot");
            return new ParkingSpotInfo(Guid.NewGuid().ToString());
        }
    }
}
