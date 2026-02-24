using System;

namespace sadittechincode
{
    public class Guest : User
    {
        public string Workplace;
        public string Position;

        public void Show()
        {
            ShowBasic();
            Console.WriteLine("Workplace: " + Workplace);
            Console.WriteLine("Position: " + Position);
            Console.WriteLine("-------------------");
        }
    }
}