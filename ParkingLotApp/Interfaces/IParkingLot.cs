using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Interfaces
{
    public interface IParkingLot
    {
        bool AllocateSpot(IVehicle _v);
        void DeAllocateSpot(IVehicle _v);
        void AddLevels(int n);
        void AddSmallSpots(int n);
        void AddCompactSpots(int n);
        void AddLargeSpots(int n);
        void AddXLargeSpots(int n);
    }
}
