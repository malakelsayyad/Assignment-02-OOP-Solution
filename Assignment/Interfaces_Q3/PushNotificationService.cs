using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interfaces_Q3
{
    public class PushNotificationService : INotificationService
    {
        public void SendNotification(Recipient recipent, string message)
        {
            Console.WriteLine($"{recipent.Name} is sending a Notification and it is : {message}");
        }
    }
}
