using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class HotelManagementSystem
    {
        private List<Reservation> _reservations = new List<Reservation>();
        private List<Hotel> _hotels = new List<Hotel>();
        private List<User> _users = new List<User>();
        public void AddHotel(Hotel hotel)
        {
            _hotels.Add(hotel);
        }
        public void RegisterUser(User user)
        {
            _users.Add(user);
        }

        public void DisplayHotels()
        {
            Console.WriteLine("List of Hotels:");
            foreach (var hotel in _hotels)
            {
                Console.WriteLine(hotel.Name + ", " + hotel.Address);
            }
        }
        public Reservation BookReservation(Hotel hotel, HotelRoom room, Guest guest, DateTime checkInDate, DateTime checkOutDate)
        {
            guest.TotalRoomCount++;
            var reservation = new Reservation(checkInDate, checkOutDate, room);
            guest.Reservations.Add(reservation);
            _reservations.Add(reservation);
            return reservation;
        }

        public void DisplayReservationDetails(int reservationNumber)
        {
            Console.WriteLine($"\nDetails of Reservation {reservationNumber}:");
            foreach (var reservation in _reservations)
            {
                if (reservation.ReservationNumber == reservationNumber)
                {
                    Console.WriteLine($"{reservation.ReservationNumber} Start Time: {reservation.CheckIn}, End Time {reservation.CheckOut}, Duration: {reservation.Duration}, Total: {reservation.Price} ");
                }
            }
        }
    }

 }



