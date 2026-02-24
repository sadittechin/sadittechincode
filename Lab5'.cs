using System;
using System.Collections.Generic;

namespace sadittechincode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Guest> guests = new List<Guest>();
            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                Console.WriteLine("===== Training System =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Teacher");
                Console.WriteLine("3. Add Guest");
                Console.WriteLine("4. Add Trainer");
                Console.WriteLine("5. Show All");
                Console.WriteLine("0. Exit");
                Console.Write("Select: ");

                string menu = Console.ReadLine();

                if (menu == "0")
                    break;

                if (menu == "1")
                {
                    Student s = new Student();
                    Console.Write("Firstname: ");
                    s.Firstname = Console.ReadLine();
                    Console.Write("Lastname: ");
                    s.Lastname = Console.ReadLine();
                    Console.Write("Email: ");
                    s.Email = Console.ReadLine();
                    Console.Write("Phone: ");
                    s.Phone = Console.ReadLine();
                    Console.Write("Student ID: ");
                    s.StudentID = Console.ReadLine();
                    Console.Write("Major: ");
                    s.Major = Console.ReadLine();

                    students.Add(s);
                }
                else if (menu == "2")
                {
                    Teacher t = new Teacher();
                    Console.Write("Firstname: ");
                    t.Firstname = Console.ReadLine();
                    Console.Write("Lastname: ");
                    t.Lastname = Console.ReadLine();
                    Console.Write("Email: ");
                    t.Email = Console.ReadLine();
                    Console.Write("Phone: ");
                    t.Phone = Console.ReadLine();
                    Console.Write("Major: ");
                    t.Major = Console.ReadLine();
                    Console.Write("Position: ");
                    t.Position = Console.ReadLine();

                    teachers.Add(t);
                }
                else if (menu == "3")
                {
                    Guest g = new Guest();
                    Console.Write("Firstname: ");
                    g.Firstname = Console.ReadLine();
                    Console.Write("Lastname: ");
                    g.Lastname = Console.ReadLine();
                    Console.Write("Email: ");
                    g.Email = Console.ReadLine();
                    Console.Write("Phone: ");
                    g.Phone = Console.ReadLine();
                    Console.Write("Workplace: ");
                    g.Workplace = Console.ReadLine();
                    Console.Write("Position: ");
                    g.Position = Console.ReadLine();

                    guests.Add(g);
                }
                else if (menu == "4")
                {
                    Trainer tr = new Trainer();
                    Console.Write("Firstname: ");
                    tr.Firstname = Console.ReadLine();
                    Console.Write("Lastname: ");
                    tr.Lastname = Console.ReadLine();
                    Console.Write("Email: ");
                    tr.Email = Console.ReadLine();
                    Console.Write("Phone: ");
                    tr.Phone = Console.ReadLine();

                    trainers.Add(tr);
                }
                else if (menu == "5")
                {
                    Console.WriteLine("----- Students -----");
                    foreach (var s in students)
                        s.Show();

                    Console.WriteLine("----- Teachers -----");
                    foreach (var t in teachers)
                        t.Show();

                    Console.WriteLine("----- Guests -----");
                    foreach (var g in guests)
                        g.Show();

                    Console.WriteLine("----- Trainers -----");
                    foreach (var tr in trainers)
                        tr.Show();
                }
            }
        }
    }
}