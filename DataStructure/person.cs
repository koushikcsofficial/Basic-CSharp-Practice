using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class person
    {
        public int roll;
        public string name;
        public person(string name, int roll)
        {
            this.roll = roll;
            this.name = name;
        }
        public string combine()
        {
            return "name: " + name + " Roll: " + roll;
        }
    }
}
