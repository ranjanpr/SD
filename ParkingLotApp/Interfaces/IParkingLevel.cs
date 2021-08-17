using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Interfaces
{

    public interface IParkingLevel
    {
        void Init(IParkingStartegy strategy);
        void AddParkingSpot(IParkingSpot spot);
        void RemoveParkingSpot(IParkingSpot spot);

        int GetParkingSpotsAvailable();
        bool HasParkingSpotAvailable(IVehicle vehicle);
        void ParkVehicle(IVehicle vehicle);
        void ClearParking(IVehicle vehicle);
    }

    public class ParkingLevel : IParkingLevel
    {
        private IList<IParkingSpot> mParkingSpots;
        private IParkingStartegy mParkingStrategy;
        public ParkingLevel()
        {
            mParkingSpots = new List<IParkingSpot>();
        }

        public void Init(IParkingStartegy strategy)
        {
            mParkingStrategy = strategy;
        }

        public void AddParkingSpot(IParkingSpot spot)
        {
            mParkingSpots.Add(spot);
        }

        public void RemoveParkingSpot(IParkingSpot spot)
        {
            mParkingSpots.Remove(spot);
        }

        public bool HasParkingSpotAvailable(IVehicle vehicle)
        {
            return mParkingSpots.Where(x => x.IsEmpty() && x.GetSize()==vehicle.GetVehicleSize()).Count() > 0;
        }

        public void ClearParking(IVehicle vehicle)
        {
            try
            {
                // clear parking for the vehicle
                mParkingSpots.Where(x => x.GetId() == vehicle.GetParkedSpot()).First().RemoveVehicle(vehicle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new InvalidOperationException("Exception! Unable to remove vehicle");
            }
        }

        public int GetParkingSpotsAvailable()
        {
            return mParkingSpots.Where(x => x.IsEmpty()).Count();
        }

        public void ParkVehicle(IVehicle vehicle)
        {
            try
            {
                // Find the available spot and park the vehicle in that spot
                var parkingInfo = mParkingStrategy.FindParkingSpot(vehicle);
                mParkingSpots.Where(x => x.GetId() == parkingInfo.SpotId).First().ParkVehicle(vehicle, parkingInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new InvalidOperationException("Exception! Unable to park vehicle at this time");
            }
        }

    }
}
