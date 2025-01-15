using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interfaces_Q2
{ 

   public interface IAuthenticationService
      {
         public bool AuthenticateUser (User user);
         public bool AuthorizeUser (User user);
      }
}
