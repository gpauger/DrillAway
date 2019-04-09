using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillAway
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(drills.Likes(new string[] { "Peter" }));
            Console.ReadLine();
            Console.WriteLine(drills.Likes(new string[] { "Jacob", "Alex" }));
            Console.ReadLine();
            Console.WriteLine(drills.Likes(new string[] { "Max", "John", "Mark" }));
            Console.ReadLine();
            Console.WriteLine(drills.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
            Console.ReadLine();
        }
    }
}
