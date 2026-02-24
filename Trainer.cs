using System;

namespace sadittechincode
{
    public class Trainer : User
    {
        public void Show()
        {
            ShowBasic();
            Console.WriteLine("Role: Trainer");
            Console.WriteLine("-------------------");
        }
    }
}