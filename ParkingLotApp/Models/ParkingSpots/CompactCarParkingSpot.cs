using ParkingLotApp.Interfaces;
using ParkingLotApp.Models;
using ParkingLotApp.Utils;
using System;

namespace ParkingLotApp.Models.ParkingSpots
{
    public class CompactCarParkingSpot : IParkingSpot
    {
        private ParkingSpotInfo SpotInfo;
        private bool isEmpty = true;

        public CompactCarParkingSpot()
        {
            SpotInfo = new ParkingSpotInfo(Guid.NewGuid().ToString());
        }

        public string GetId()
        {
            return SpotInfo.SpotId;
        }

        public eVehicleSize GetSize()
        {
            return eVehicleSize.SIZE_COMPACT;
        }

        public bool IsEmpty()
        {
            return isEmpty;
        }

        public void ParkVehicle(IVehicle vehicle, ParkingSpotInfo _info)
        {
            if (isEmpty && vehicle.CanFitInSpot(this))
            {
                isEmpty = false;
                SpotInfo = _info;
                vehicle.ReserveSpot(this);
            }
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            isEmpty = true;
            vehicle.FreeSpot();
        }
    }
}