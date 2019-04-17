using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 1,3,4,7,8,9,12,13,15,18};

            Program p = new Program();
            Console.WriteLine(p.BinarySearch(arry,3));
            Console.WriteLine(p.BinarySearchRecursion(arry,0,arry.Length-1, 7));
            
        }

        public int BinarySearch(int[] arry,int value)
        {
            //排序

            int left = 0;
            int right = arry.Length - 1;

            while(left <= right)
            {
                int mid = (right + left) / 2;
                if(arry[mid] < value)
                {
                    left = mid + 1;
                }
                else if(arry[mid] > value)
                {
                    right = mid - 1;
                }
                else
                {
                    return mid + 1;
                }
            }

            return -1;
        }

        //递归
        public int BinarySearchRecursion(int[] arry, int left, int right, int value)
        {
            //排序            

            if(left <= right)
            {
                int mid = (right + left) / 2;
                if (arry[mid] < value)
                {
                    left = mid + 1;
                    return BinarySearchRecursion(arry, left, right, value);
                }
                else if (arry[mid] > value)
                {
                    right = mid - 1;
                    return BinarySearchRecursion(arry, left, right, value);
                }
                else
                {
                    return mid + 1;
                }
            }
         
            return -1;
        }
    }
}
