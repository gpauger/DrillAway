using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillAway
{
    public static class drills
    {

        public static string Likes(string[] name)
        {
            int x = name.Count();
            int rest = x - 2;
            if (x == 0)
            { return "no one likes this"; }
            else if (x == 1)
            { return name[0] + " likes this"; }
            else if (x == 2)
            { return name[0] + " and " + name[1] + " like this"; }
            else if (x == 3)
            { return name[0] + ", " + name[1] + " and " + name[2] + " like this"; }
            else if (x > 3)
            { return name[0] + ", " + name[1] + " and " + rest + " others like this"; }
            else return "oops";
        }
    }
}

