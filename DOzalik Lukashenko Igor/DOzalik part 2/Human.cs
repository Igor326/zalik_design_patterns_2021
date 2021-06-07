using System;
using System.Collections.Generic;
using System.Text;

namespace DOzalik_part_2
{
    class Human
    {
        public Location Location { get; set; }
        public void Launch(string osName)
        {
            Location = Location.getInstance(osName);
        }
    }
}
