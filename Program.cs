using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration
            string name = "Anna";
            int age = 35;
            bool isTall = false;
            double weight = 65.5;

            /*for the samallest least precise decimal use float,
             * for more precise use decimal e.g money
             * in most cases double will ddo just fine
             * */

            Console.WriteLine(name + " is " + age + ", she weighs " + weight);
            Console.WriteLine(" It is" + isTall + " that she is tall.");

            //freeeze console
            Console.ReadLine();

        }
    }
}
