using ParkingLotApp.Models;

namespace ParkingLotApp.Interfaces
{
    public interface IParkingStartegy
    {
        ParkingSpotInfo FindParkingSpot(IVehicle vehicle);
    }
}
