using System;
namespace Assignment_6
{
    public interface ICustomer
    {
        string Name
        {
            get;
        }

        string Address
        {
            get;
        }

        string RoomNumber
        {
            get;
        }

        DateTime ArrivalDate
        {
            get;
        }

        int NumberOfNights
        {
            get;
        }
    }
}
