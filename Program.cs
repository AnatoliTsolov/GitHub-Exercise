using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            if (num >= 0)
            {
                try
                {
                    long biggestInt = (long)num;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"{num} can't fit in any type");
                }
                try
                {
                    sbyte sbyteNumber = (sbyte)num;
                    Console.WriteLine($"{num} can fit in:\n* sbyte\n* byte\n* short\n* ushort\n* int\n* uint\n* long");
                    return;
                }
                catch (OverflowException)
                {

                }
                try
                {
                    short shortNumber = (short)num;
                    Console.WriteLine($"{num} can fit in:\n* short\n* ushort\n* int\n* uint\n* long");
                    return;
                }
                catch (OverflowException)
                {

                }
                try
                {
                    ushort ushortNumber = (ushort)num;
                    Console.WriteLine($"{num} can fit in:\n* ushort\n* int\n* uint\n* long");
                    return;
                }
                catch (OverflowException)
                {

                }
                try
                {
                    int intNumber = (int)num;
                    Console.WriteLine($"{num} can fit in:\n* int\n* uint\n* long");
                    return;
                }
                catch (Exception)
                {

                }
                try
                {
                    uint uintNumber = (uint)num;
                    Console.WriteLine($"{num} can fit in:\n* uint\n* long");
                    return;
                }
                catch (Exception)
                {

                }
                try
                {
                    long longNumber = (long)num;
                    Console.WriteLine($"{num} can fit in:\n* long");
                    return;
                }
                catch (Exception)
                {

                }
            }
            else
            {
                try
                {
                    sbyte sbyteNumber = (sbyte)num;
                    Console.WriteLine($"{num} can fit in:\n* sbyte\n* short\n* int\n* long");
                    return;
                }
                catch (OverflowException)
                {

                }
                try
                {
                    short shortNegative = (short)num;
                    Console.WriteLine($"{num} can fit in:\n* short\n* int\n* long");
                    return;
                }
                catch (Exception)
                {

                }
                try
                {
                    int intNegative = (int)num;
                    Console.WriteLine($"{num} can fit in:\n* int\n* long");
                    return;
                }
                catch (Exception)
                {

                }
                try
                {
                    long longNegative = (long)num;
                    Console.WriteLine($"{num} can fit in:\n* long");
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
