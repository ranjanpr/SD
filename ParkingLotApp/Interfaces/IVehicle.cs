using ParkingLotApp.Models;
using ParkingLotApp.Utils;
using System;

namespace ParkingLotApp.Interfaces
{
    public interface IVehicle
    {
        void Init(eVehicleSize size);
        bool CanFitInSpot(IParkingSpot parkingSpot);
        void FreeSpot();
        void ReserveSpot(IParkingSpot parkingSpot);
        String GetParkedSpot();
        eVehicleSize GetVehicleSize();
    }

    public class Bike : IVehicle
    {
        private int mVehicleId;
        private eVehicleSize mSize;
        private IParkingSpot mSpot;
        public Bike(int _id)
        {
            mVehicleId = _id;
        }
        public bool CanFitInSpot(IParkingSpot spot)
        {
            return mSize == spot.GetSize();
        }

        public void FreeSpot()
        {
            mSpot = null;
        }

        public String GetParkedSpot()
        {
            return mSpot.GetId();
        }

        public eVehicleSize GetVehicleSize()
        {
            return mSize;
        }

        public void Init(eVehicleSize size)
        {
            mSize = size;
        }

        public void ReserveSpot(IParkingSpot parkingSpot)
        {
            mSpot = parkingSpot;
        }
    }
}