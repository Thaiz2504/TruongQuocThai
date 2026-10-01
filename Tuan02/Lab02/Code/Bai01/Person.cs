using System;

namespace Bai01
{
    public class Person
    {
        private int id;
        private string name = "";
        private int yob;
        private int yod;

        // Default Constructor
        public Person()
        {
            id = 0;
            name = "";
            yob = 0;
            yod = 0;
        }

        // Copy Constructor
        public Person(Person other)
        {
            id = other.id;
            name = other.name;
            yob = other.yob;
            yod = other.yod;
        }

        public void Input()
        {
            Console.Write("Nhap id: ");
            id = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap ho ten: ");
            name = Console.ReadLine() ?? "";

            Console.Write("Nhap nam sinh: ");
            yob = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap nam mat (0 neu con song): ");
            yod = int.Parse(Console.ReadLine() ?? "0");
        }

        public void Output()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Ho ten: " + name);
            Console.WriteLine("Nam sinh: " + yob);
            Console.WriteLine("Nam mat: " + yod);
        }

        public bool IsLiving()
        {
            return yod == 0;
        }
    }
}