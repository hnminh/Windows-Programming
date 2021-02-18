using System;
namespace Assignment_6
{
    public interface IRoom
    {
        string RoomNumber
        {
            get;
        }

        string Area
        {
            get;
        }

        string Type
        {
            get;
        }

        double Price
        {
            get;
        }

        string Description
        {
            get;
        }
    }
}
