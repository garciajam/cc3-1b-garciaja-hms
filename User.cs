using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public abstract class User
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }

        public User(string name, string address, string email, int number)
        {
            Name = name;
            Address = address;
            Email = email;
            Number = number;
        }

    }
}
