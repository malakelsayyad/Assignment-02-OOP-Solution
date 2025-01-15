using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interfaces_Q2
{

    public class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(User user)
        {
            if(user.Name != null)
                return true;
            return false;
        }

        public bool AuthorizeUser(User user)
        {
            if (user.Role.ToLower() == "admin")
              return true;
            return false;
        }
    }
}

