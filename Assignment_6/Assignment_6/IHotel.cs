using System;
using System.Collections;

namespace Assignment_6
{
    public interface IHotel
    {
        string Name
        {
            get;
        }

        DateTime ConstructionDate
        {
            get;
        }

        string Address
        {
            get;
        }

        int NumberOfStars
        {
            get;
        }

        ArrayList Rooms
        {
            get;
            set;
        }

        ArrayList Customers
        {
            get;
            set;
        }

    }
}
