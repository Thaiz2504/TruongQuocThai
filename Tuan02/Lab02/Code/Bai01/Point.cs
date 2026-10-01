using System;

namespace Bai01
{
    public class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Input()
        {
            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap y: ");
            y = double.Parse(Console.ReadLine() ?? "0");
        }

        public void Output()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }

        public double Distance(Point other)
        {
            double dx = x - other.x;
            double dy = y - other.y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static double Distance(Point A, Point B)
        {
            double dx = A.x - B.x;
            double dy = A.y - B.y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        public Point MidPoint(Point other)
        {
            return new Point(
                (x + other.x) / 2,
                (y + other.y) / 2
            );
        }

        public static Point MidPoint(Point A, Point B)
        {
            return new Point(
                (A.x + B.x) / 2,
                (A.y + B.y) / 2
            );
        }

        public static Point operator +(Point A, Point B)
        {
            return new Point(
                A.x + B.x,
                A.y + B.y
            );
        }

        public static Point operator -(Point A, Point B)
        {
            return new Point(
                A.x - B.x,
                A.y - B.y
            );
        }

        public static Point operator -(Point A)
        {
            return new Point(
                -A.x,
                -A.y
            );
        }
    }
}