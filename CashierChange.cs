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
            int fiveH = 0;
            int oneH = 0;
            int fifty = 0;
            int twenty = 0;
            int ten = 0;
            int five = 0;
            int two = 0;
            int one = 0;


            Console.WriteLine("Enter an amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount >= 500)
            {
                fiveH = amount / 500;
                amount -= fiveH * 500;

            }
            
            if (amount >= 100)
            {
                oneH = amount / 100;
                amount -= oneH * 100;
            }

            if (amount >= 50)
            {
                fifty = amount / 50; 
                amount -= fifty * 50;
            }

            if (amount >= 20)
            {
                twenty = amount / 20;
                amount -= twenty * 20;
            }

            if (amount >= 10)
            {
                ten = amount / 10;
                amount -= ten * 10;
            }

            if (amount >= 5)
            {
                five = amount / 5;
                amount -= five * 5;
            }

            if (amount >= 2)
            {
                two = amount / 10;
                amount -= two * 2;
            }

            if (amount >= 1)
            {
                one = amount;
            }

            Console.WriteLine("Total notes ");
            Console.WriteLine("500 = " + fiveH);
            Console.WriteLine("100 = " + oneH);
            Console.WriteLine("50 = " + fifty);
            Console.WriteLine("20 = " + twenty);
            Console.WriteLine("10 = " + ten);
            Console.WriteLine("5 = " + five);
            Console.WriteLine("2 = " + two);
            Console.WriteLine("1 = " + one);
        }
    }
}
