using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfi
{
    public class Mechanic : Person
    {
        public int Year { get; set; }

        public int HourlyWage { get; set; }

        public Mechanic(string name, string address, int year, int hourlywage) : base(name, address)
        {
            Year = year;
            HourlyWage = hourlywage;
        }

        public override string ToString()
        {
            return Name + " er mekaniker og tjener en timeløn på " + HourlyWage;
        }

        public override double BeregnUgeLøn()

        {
            return HourlyWage * TimerPrUge;
        }
    }
}
