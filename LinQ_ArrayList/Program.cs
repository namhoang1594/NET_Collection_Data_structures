using System;
using System.Collections;
using System.Linq;

namespace LinQ_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(new Staff(1, "Nam", 24));
            array.Add(new Staff(2, "Kien", 21));
            array.Add(new Staff(3, "Viet", 21));
            array.Add(new Staff(4, "Hang", 23));
            array.Add(new Staff(5, "Tien", 24));

            var newArrayList = array.OfType<Staff>();
            var Search = from name in newArrayList
                         where (name.Age < 24)
                         select name;
            var sapxep = from name in newArrayList
                         orderby name.Name
                         select name;
            Console.WriteLine("Nhung nguoi nho hon 24 tuoi: ");
            foreach (var item in Search)
            {
                Console.WriteLine("ID: " + item.ID + ", Name: " + item.Name + ", Age: " + item.Age);
            }
            Console.WriteLine("Sap xep theo ten: ");
            foreach (var item in sapxep)
            {
                Console.WriteLine("ID: " + item.ID + ", Name: " + item.Name + ", Age: " + item.Age);
            }
        }
    }
}
