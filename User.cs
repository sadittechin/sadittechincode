using System;

namespace sadittechincode
{
    public class User
    {
        public string Firstname;
        public string Lastname;
        public string Email;
        public string Phone;

        public void ShowBasic()
        {
            Console.WriteLine("Name: " + Firstname + " " + Lastname);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Phone: " + Phone);
        }
    }
}