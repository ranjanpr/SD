using ParkingLotApp.Models;
using ParkingLotApp.Utils;
using System;

namespace ParkingLotApp.Interfaces
{
    public interface IParkingSpot
    {
        String GetId();
        eVehicleSize GetSize();
        bool IsEmpty();
        void ParkVehicle(IVehicle vehicle, ParkingSpotInfo _info);
        void RemoveVehicle(IVehicle vehicle);
    }
}