using System;

namespace sadittechincode
{
    public class Teacher : User
    {
        public string Major;
        public string Position;

        public void Show()
        {
            ShowBasic();
            Console.WriteLine("Major: " + Major);
            Console.WriteLine("Position: " + Position);
            Console.WriteLine("-------------------");
        }
    }
}