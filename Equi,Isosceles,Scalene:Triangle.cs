using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 lengths: ");

            int firstLength = Convert.ToInt32(Console.ReadLine());
            int secondLength = Convert.ToInt32(Console.ReadLine());
            int thirdLength = Convert.ToInt32(Console.ReadLine());

            if (firstLength == secondLength && secondLength == thirdLength && firstLength == thirdLength)
            {
                Console.WriteLine("equilateral");

            }
            else if (firstLength == secondLength && firstLength != thirdLength || secondLength == thirdLength && secondLength != firstLength || thirdLength == firstLength && thirdLength != secondLength)
            {
                Console.WriteLine("isosceles");
            }
            else
            {
                Console.WriteLine("scalene"); 
            }
        }
    }
}
