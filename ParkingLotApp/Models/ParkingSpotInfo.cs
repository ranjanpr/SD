using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Models
{
    public class ParkingSpotInfo
    {
        private DateTime mEntryTime;
        public DateTime EntryTime {
            get => mEntryTime;
            set => mEntryTime = value;
        }

        private DateTime mExitTime;
        public DateTime ExitTime
        {
            get => mExitTime;
            set => mExitTime = value;
        }

        private string mSpotId;
        public String SpotId
        {
            get => mSpotId;
            set => mSpotId = value;
        }
        public ParkingSpotInfo(string _id)
        {
            SpotId = _id;
        }
    }
}
