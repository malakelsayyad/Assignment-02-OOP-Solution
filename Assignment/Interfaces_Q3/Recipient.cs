using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interfaces_Q3
{
    public class Recipient
    {
        public string  Name { get; set; }
        public string Email { get; set; }

        public Recipient(string name , string email) 
        {
            Name = name;
            Email = email;
        }

    }
}
