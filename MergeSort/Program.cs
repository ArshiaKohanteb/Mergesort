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

            if (nums.Length == 1)
            {
                return nums;
            }

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

            int[] leftResult = MergeSort(left);
            int[] rightResult = MergeSort(right);

            return Merge(leftResult, rightResult);
        }

        static int[] Merge(int[] left, int[] right)
        {   // Loop until any input array has been completely copied

            // Copy the rest of left

            // copy the rest of right
            int lefti = 0;
            int righti = 0;
            int index = 0;

            int[] nums = new int[left.Length + right.Length];

            while(lefti < left.Length && righti < right.Length)
            {
                if (left[lefti] < right[righti])
                {
                    nums[index] = right[righti];
                    righti++;
                }
                else
                {
                    nums[index] = left[lefti];
                    lefti++;
                }
                index++;
            }    
            
            while(righti < right.Length)
            {
                nums[index] = right[righti];
                index++;
                righti++;
            }
            while (lefti < left.Length)
            {
                nums[index] = left[lefti];
                index++;
                lefti++;
            }
            /*
            while (!merged)
            {
                if (left[lefti] < right[righti])
                {
                    nums[index] = left[lefti];
                    lefti++;
                }
                else
                {
                    nums[index] = right[righti];
                    righti++;
                }

                index++;

                if (righti >= right.Length)
                {
                    merged = true;
                }
            }

            for (int i = index; i < nums.Length; i++, lefti++)
            {
                nums[i] = left[lefti];
            }*/
            /*
            while (!merged)
            {
                if(righti >= right.Length || left[lefti] < right[righti])
                {
                    right[righti] = nums[index];
                    righti++;
                }
                else if (lefti >= left.Length || left[lefti] > right[righti])
                {
                    left[lefti] = nums[index];
                    lefti++;
                }

                int number = 0;
                for(int i = 0; i < nums.Length;i++)
                {
                    if (nums[i] != 0)
                    {
                        number++;
                    }
                }
                if (number == nums.Length)
                    merged = true;

                index++;
            }
            */
            return nums;
        }

        static void Main(string[] args)
        {
            int[] nums = {100,200,300,400,500};
            int[] final = MergeSort(nums);
            for(int i = 0; i < final.Length;i++)
            {
                Console.WriteLine(final[i]);
            }
            Console.ReadKey();
        }
    }
}
