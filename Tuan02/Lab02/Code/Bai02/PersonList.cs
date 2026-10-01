using System.Collections;

namespace Bai02
{
    public class PersonList
    {
        private ArrayList ds;

        // Default Constructor
        public PersonList()
        {
            ds = new ArrayList();
        }

        // Copy Constructor
        public PersonList(PersonList other)
        {
            ds = new ArrayList();

            foreach (Person p in other.ds)
            {
                ds.Add(new Person(p));
            }
        }

        // Thêm Person
        public void Add(Person x)
        {
            ds.Add(x);
        }

        // Nhập danh sách
        public void Input()
        {
            Console.Write("Nhap so luong Person: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Nhap Person thu " + (i + 1) + ":");

                Person p = new Person();
                p.Input();

                Add(p);
            }
        }

        // Xuất danh sách
        public void Output()
{
    for (int i = 0; i < ds.Count; i++)
    {
        Console.WriteLine();
        Console.WriteLine("Person thu " + (i + 1) + ":");

        if (ds[i] is Person p)
        {
            p.Output();
        }
        else
        {
            Console.WriteLine(
                "Phan tu khong phai la Person."
            );
        }
    }
}
        // Lấy danh sách những người còn sống
        public PersonList LivingPeople()
        {
            PersonList result = new PersonList();

            foreach (Person p in ds)
            {
                if (p.IsLiving())
                {
                    result.Add(new Person(p));
                }
            }

            return result;
        }
    }
}