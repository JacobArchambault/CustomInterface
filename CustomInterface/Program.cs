using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Fun with Interfaces *****\n");
            /// Call Points property defined by IPointy.
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);

            // Catch a possible InvalidCastException
            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;
            if (itfPt2 != null)
                Console.WriteLine("Points: {0}", itfPt2.Points);
            else
                Console.WriteLine("OOPS! Not pointy...");
            Console.ReadLine();
        }
    }
}
