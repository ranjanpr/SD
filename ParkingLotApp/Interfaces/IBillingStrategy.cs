using ParkingLotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Interfaces
{
    public interface IBillingStrategy
    {
        double GetCharges(ParkingSpotInfo _info);
    }

    public class PerHourBillingStrategy : IBillingStrategy
    {
        private double mPerHourCharge;
        public PerHourBillingStrategy(double _perHourCharge)
        {
            mPerHourCharge = _perHourCharge;
        }

        public double GetCharges(ParkingSpotInfo _info)
        {
            return (_info.ExitTime - _info.EntryTime).TotalSeconds / 3600 * mPerHourCharge;
        }
    }

    public class FreeBillingStrategy : IBillingStrategy
    {
        public double GetCharges(ParkingSpotInfo _info)
        {
            return 0.0;
        }
    }

}
