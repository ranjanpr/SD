using System;

namespace ParkingLotApp.Exceptions
{
    public class InvalidOperationException : Exception
    {
        public InvalidOperationException()
        {
        }

        public InvalidOperationException(string message)
            : base(message)
        {
        }

        public InvalidOperationException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
