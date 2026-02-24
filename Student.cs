using System;

namespace sadittechincode
{
    public class Student : User
    {
        public string StudentID;
        public string Major;

        public void Show()
        {
            ShowBasic();
            Console.WriteLine("Student ID: " + StudentID);
            Console.WriteLine("Major: " + Major);
            Console.WriteLine("-------------------");
        }
    }
}