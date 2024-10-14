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
            int largest;

            Console.WriteLine("Enter four numbers: ");
            int firstN = Convert.ToInt32(Console.ReadLine());
            int secondN = Convert.ToInt32(Console.ReadLine());
            int thirdN = Convert.ToInt32(Console.ReadLine());
            int fourthN = Convert.ToInt32(Console.ReadLine());

            if (firstN > secondN)
            {
                if (firstN > thirdN)
                {
                    if (firstN > fourthN)
                        largest = firstN;
                    else
                        largest = fourthN;
                }
                else
                {
                    if (thirdN > fourthN)
                        largest = thirdN;
                    else
                        largest = fourthN;
                }
            }
            else
            {
                if (secondN > thirdN)
                {
                    if (secondN > fourthN)
                        largest = secondN;
                    else
                        largest = fourthN;
                }
                else
                {
                    if (thirdN > fourthN)
                        largest = thirdN;
                    else
                        largest = fourthN;
                }
            }
            Console.WriteLine("largest is: " + largest);
        }
    }
}
