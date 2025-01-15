using Assignment.Interfaces_Q1;
using Assignment.Interfaces_Q2;
using Assignment.Interfaces_Q3;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            // b) To define a blueprint for a class
            // a) Private
            // b) No
            // b) Yes, interfaces can inherit from multiple interfaces
            // d) implements
            // a) Yes
            // b) No, all members are implicitly public
            // a) To hide the interface members from outside access
            // b) No, interfaces cannot have constructors
            // c) By separating interface names with commas

            #endregion

            #region Part02

            #region Q01
            // Circle circle = new Circle(4);
            // circle.DisplayShapeInfo();

            //Rectangle rectangle = new Rectangle(4, 5);
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Q02
            //User[] user = new User[2];

            //user[0] = new User("Malak","123","Admin");
            //user[1] = new User("Mohamed","123","User");


            //BasicAuthenticationService basicAuthenticationService = new BasicAuthenticationService();

            //bool result1 = basicAuthenticationService.AuthenticateUser(user[0]);
            //Console.WriteLine(result1);


            //bool result2 = basicAuthenticationService.AuthorizeUser(user[1]);
            //Console.WriteLine(result2); 
            #endregion

            #region Q03

            //Recipient recipient = new Recipient("Malak","M@gmail.com");

            //EmailNotificationService EmailService = new EmailNotificationService();
            //SmsNotificationService SmsService = new SmsNotificationService();
            //PushNotificationService PushNotificationService = new PushNotificationService();

            //EmailService.SendNotification(recipient,"Hello");
            //SmsService.SendNotification(recipient,"Hello");
            //PushNotificationService.SendNotification(recipient,"Hello");

            #endregion

            #endregion
        }
    }
}
