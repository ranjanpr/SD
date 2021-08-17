using ParkingLotApp.Controller;
using ParkingLotApp.Interfaces;
using ParkingLotApp.Models;
using ParkingLotApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParkingLotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new ParkingLotController();
            var builder = new ParkingLotBuilder();
            controller.Builder = builder;

            controller.BuildMinimalParkingLot();

            List<int> vehicleIds = new List<int>();

            // ToDo create event loop for vehicle arriving and exiting
            bool bRunParkingLot = true;
            while (bRunParkingLot)
            {
                for (int i = 0; i < 1000; i++)
                {
                    bool isArriving = Helper.NextBoolean(new Random());

                    if (isArriving)
                    {
                        // generate a random id for the arriving vehicle
                        int nextVehicleId = -1; 
                        while(vehicleIds.Exists(id => id == nextVehicleId))
                        {
                            nextVehicleId = Helper.NextId(new Random());
                        }
                        
                        // try to park in parking lot
                        bool b = builder.GetParkingLot()
                            .AllocateSpot(new Bike(nextVehicleId));
                        if (!b)
                        {
                            Console.WriteLine("Spots not available for parking");
                        }
                        else
                        {
                            vehicleIds.Add(nextVehicleId);
                        }
                    }
                    else
                    {
                        // randomly pick one vehicle from ids list and remove
                        int nextVehicleId = Helper.NextId(new Random(), vehicleIds.Count);

                        // take the vehicle out
                        builder.GetParkingLot().DeAllocateSpot(new Bike(nextVehicleId));

                        vehicleIds.Remove(nextVehicleId);
                    }
                    Thread.Sleep(200);
                }
                bRunParkingLot = false;
            }

            return;
        }
    }
}
