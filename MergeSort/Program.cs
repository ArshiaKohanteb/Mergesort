using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static int[] MergeSort(int[] nums)
        {
            //split it into 2 arrays
            //Checks if even

            int[] left = new int[nums.Length / 2];
            int[] right = new int[nums.Length / 2];

            if (nums.Length % 2 == 1)
            {
                left = new int[nums.Length / 2 + 1];
            }

            int numsIndex = 0;

            for (int i = 0; i < (nums.Length % 2 == 0 ? nums.Length / 2 : nums.Length / 2 + 1); i++, numsIndex++)
            {
                left[i] = nums[numsIndex];
            }

            for (int i = 0; i < nums.Length / 2; i++, numsIndex++)
            {
                right[i] = nums[numsIndex];
            }

            if (left.Length == 1)
            {
                return left;
            }

            return Merge(MergeSort(left), MergeSort(right));
        }

        static int[] Merge(int[] left, int[] right)
        {
            int lefti = 0;
            int righti = 0;
            int index= 0;

            int[] nums = new int[left.Length + right.Length];

            bool merged = false;

            while(merged == false)
            {
                if (left[lefti] < right[righti])
                {
                    nums[index] = left[lefti];
                    lefti++;
                    index++;
                }
                else
                {
                    nums[index] = right[righti];
                    righti++;
                    index++;
                }
            }

            return nums;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            nums = MergeSort(nums);
        }
    }
}
