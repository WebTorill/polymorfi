using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfi
{
    public class Foreman : Mechanic
    {
        public int YearF { get; set; }
        public int Addition { get; set; }

        public Foreman(string name, string address, int year, int hourlywage, int yearforeman, int addition) : base(name, address, year, hourlywage)
        {
            YearF = yearforeman;
            Addition = addition;
        }

        public override string ToString()
        {
            return Name + " er værkfører og har et tillæg på " + Addition;
        }

        public override double BeregnUgeLøn()

        {
            return (HourlyWage * TimerPrUge) + Addition;
        }
    }
}
