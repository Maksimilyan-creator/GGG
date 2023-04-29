using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGG
{
    internal class Sick
    {
        public string Name { get; set; }
        public string Disease { get; set; }
        public string State { get; set; }
        public Sick (string name, string disease, string state)
        {
            Name = name;
            Disease = disease;
            State = state;
        }

    }
}
