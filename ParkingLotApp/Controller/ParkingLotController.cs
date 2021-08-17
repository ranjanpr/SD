using ParkingLotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Controller
{
    public class ParkingLotController
    {
        private IBuilder mBuilder;
        public IBuilder Builder
        {
            set { mBuilder = value; }
        }

        public void BuildMinimalParkingLot()
        {
            mBuilder.Levels(2);
            mBuilder.SmallSpots(20);
            mBuilder.CompactSpots(10);
            mBuilder.LargeSpots(10);
            mBuilder.XLargeSpots(5);
        }
    }
}
