using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Utils
{
    public enum eVehicleSize
    {
        SIZE_SMALL,
        SIZE_COMPACT,
        SIZE_LARGE,
        SIZE_XLARGE
    };

    public static class Helper
    {
        public static bool NextBoolean(this Random random)
        {
            return random.Next() > (Int32.MaxValue / 2);
            // Next() returns an int in the range [0..Int32.MaxValue]
        }

        public static int NextId(this Random random)
        {
            return random.Next() % 5000;
        }
        public static int NextId(this Random random, int N)
        {
            return random.Next() % N;
        }
    }
}
