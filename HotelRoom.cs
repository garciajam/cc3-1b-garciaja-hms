using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public enum RoomStyle
    {
        TwinRoom,
        KingRoom,
        QueenRoom
    }
    public class HotelRoom
    {
        public int RoomNumber { get; private set; }
        public RoomStyle Style { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public HotelRoom(int roomnumber, RoomStyle style, int price)
        {
            RoomNumber = roomnumber;
            Style = style;
            Price = price;
            Status = false;
        }
    }
}
