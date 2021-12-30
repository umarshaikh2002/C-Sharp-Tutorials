using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorials
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;
            nums[4] = 5;

            try
            {
                nums[5] = (int)6/1;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("1");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("2");
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.WriteLine("--------------------------------------------------");

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------------------");

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(nums[i]);
            }

            int index = Array.IndexOf(nums, 3);

            Console.WriteLine("index at 1 " + index);

            Console.WriteLine("------------------------two-dimensional Array--------------------------");

            //int[,,] arr3d = new int[2, 2, 2] {
            //    {
            //        {1, 2},
            //        {3, 4}
            //    },
            //    {
            //        {5, 6},
            //        {7, 8}
            //    }

            //    };

            //Console.WriteLine(arr3d[1, 0, 1]);

            int[,] arr2d = new int[2, 2] {
                    {1, 2},
                    {3, 4}
                };

            for(int i = 0;i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    Console.WriteLine(arr2d[i, j]);
                }
            }

            Console.ReadKey();
        }

    }
}
