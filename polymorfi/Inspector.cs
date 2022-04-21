using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfi
{
    public class Inspector : Mechanic
    {
        public int NoOfInspections { get; set; }

        public Inspector(string name, string address, int year, int hourlywage, int inspections) : base (name, address, year, hourlywage)
        {
            NoOfInspections = inspections;
        }

        public override string ToString()
        {
            return Name + " er synsmand og har lavet " + NoOfInspections + " syn denne uge.";
        }

        public override double BeregnUgeLøn()

        {
            return NoOfInspections * 290;
        }
    }
}
