using System;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums1 = { 10, 20, 30, 40, 50 };
            double[] nums2 = { 2.5, 3.5, 4.5, 5.5, 6.5, 7.5, 8.5 };

            double[] products = new double[Math.Max(nums1.Length, nums2.Length)];

            Console.WriteLine($"{"Array 1",10}{"Array 2",10}{"Product",10}");
            Console.WriteLine();

            for (int i = 0; i < products.Length; i++)
            {
                double value1 = 1;
                double value2 = 1;

                if (i < nums1.Length)
                {
                    value1 = nums1[i];
                }

                if (i < nums2.Length)
                {
                    value2 = nums2[i];
                }

                products[i] = value1 * value2;

                Console.WriteLine($"{value1,10:F2}{value2,10:F2}{products[i],10:F2}");
            }

            Console.ReadKey();
        }
    }
}