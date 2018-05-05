using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static int[] Helper(int[] nums)
        {
            bool even = false;
            return MergeSort(nums,even)
        }
        static int[] MergeSort(int[] nums, bool even)
        {
            if (nums % 2 == 0)
            {
                even = true;
            }
            int[] left;
            int[] right;
            //split it into 2 arrays
            if (even)//Checks if even
            {
                
            }
            else
            {

            }
            return Merge(MergeSort(left), MergeSort(right));
        }

        static int[] Merge(int[] left, int[] right)
        {

        }

        static void Main(string[] args)
        {
            
        }
    }
}
