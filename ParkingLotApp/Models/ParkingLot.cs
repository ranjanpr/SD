using ParkingLotApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Models
{
    public class ParkingLot : IParkingLot
    {
        ParkingLevel[] mParkingLevels;
        public ParkingLot()
        {

        }


        public void AddLevels(int n)
        {
            mParkingLevels = new ParkingLevel[n];
            foreach (var level in mParkingLevels)
            {
                level.Init(new NearestToExitParkingStrategy());
            }
        }

        public void AddSmallSpots(int n)
        {
            foreach (var level in mParkingLevels)
            {
                for (int i = 0; i < n; i++)
                {
                    level.AddParkingSpot(new BikeParkingSpot());
                }
            }
        }

        public void AddCompactSpots(int n)
        {
            foreach (var level in mParkingLevels)
            {
                for (int i = 0; i < n; i++)
                {
                    level.AddParkingSpot(new CompactCarParkingSpot());
                }
            }
        }

        public void AddLargeSpots(int n)
        {
            foreach (var level in mParkingLevels)
            {
                for (int i = 0; i < n; i++)
                {
                    level.AddParkingSpot(new BikeParkingSpot());
                }
            }
        }

        public void AddXLargeSpots(int n)
        {
            foreach (var level in mParkingLevels)
            {
                for (int i = 0; i < n; i++)
                {
                    level.AddParkingSpot(new BikeParkingSpot());
                }
            }
        }

        public bool AllocateSpot(IVehicle vehicle)
        {
            try
            {
                mParkingLevels.Where(x => x.HasParkingSpotAvailable(vehicle)).First().ParkVehicle(vehicle);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void DeAllocateSpot(IVehicle vehicle)
        {
            try
            {
                foreach (var level in mParkingLevels)
                {
                    level.ClearParking(vehicle);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }

    public interface IBuilder
    {
        void Levels(int n);
        void SmallSpots(int n);
        void CompactSpots(int n);
        void LargeSpots(int n);
        void XLargeSpots(int n);
    }

    public class ParkingLotBuilder : IBuilder
    {
        private IParkingLot mParkingLot = new ParkingLot();

        public ParkingLotBuilder()
        {
            mParkingLot = new ParkingLot();
        }

        // All production steps work with the same product instance.
        public void Levels(int n)
        {
            mParkingLot.AddLevels(n);
        }

        public void SmallSpots(int _smallSpots)
        {
            mParkingLot.AddSmallSpots(_smallSpots);
        }

        public void CompactSpots(int _compactSpots)
        {
            mParkingLot.AddCompactSpots(_compactSpots);
        }

        public void LargeSpots(int _smallSpots)
        {
            mParkingLot.AddLargeSpots(_smallSpots);
        }

        public void XLargeSpots(int _xlargeSpots)
        {
            mParkingLot.AddXLargeSpots(_xlargeSpots);
        }

        public IParkingLot GetParkingLot()
        {
            return mParkingLot;
        }
    }
}
