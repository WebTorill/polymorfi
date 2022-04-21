using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfi
{
    public class Person
    {
        private const int _timerPrUge = 37;



        public virtual double BeregnUgeLøn()

        {

            return 0.0;

        }

        public int TimerPrUge  //og den tilhørende access metode, bemærk readOnly, dvs get!

        {

            get { return _timerPrUge; }

        }
        public string Name { get; set; }

        public string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
