using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Guest : User
    {
        public int TotalRoomCount { get; set; }
        public List<Reservation> Reservations = new List<Reservation>();

        public Guest(string name, string address, string email, int number) : base(name, address, email, number)
        {

        }
        public void DisplayReservations()
        {
            Console.WriteLine($"\nList of Reservations of {Name}:");
            foreach (Reservation reservation in Reservations)
            {
                Console.WriteLine($"{reservation.ReservationNumber} Start Time: {reservation.CheckIn}, End Time {reservation.CheckOut}, Duration: {reservation.Duration}, Total: {reservation.Price} ");
            }
        }
    }
}

