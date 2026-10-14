using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDB
{
    internal class Actor
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }

        public Actor(string name, int birthyear)
        {
            Name= name;
            BirthYear= birthyear;
        }
    }
}
