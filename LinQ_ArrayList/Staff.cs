using System;
using System.Collections.Generic;
using System.Text;

namespace LinQ_ArrayList
{
    class Staff
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        public Staff(int ID, string Name, int Age)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }
    }
}
