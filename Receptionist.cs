using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Receptionist : User
    {
        public Receptionist(string name, string address, string email, int number) : base(name, address, email, number)
        {
        }
        public void BookReservation(Guest guest, Reservation reservation)
        {
            guest.TotalRoomCount++;
            guest.Reservations.Add(reservation);
        }
    }

}

