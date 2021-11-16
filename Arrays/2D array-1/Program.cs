using System;
using System.Collections.Generic;

namespace _2D_array_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = {9,4,2,54,1};
            int[] arr2 = {1,5,63,2,8};
            min(arr1);
            min(arr2);
            max(arr1);
            max(arr2);
            array(arr1);
            array(arr2);
            Length(arr1);
            Length(arr2);
            jagged();
        }
        static void array(int[] arr)
        {
            Console.WriteLine("Print the array elements :  ");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]);
            }
        }
        static void min(int[] arr)
        {
            int min = arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                if(min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Min Elements is : "+min);
        }
        static void max(int[] arr)
        {
            int max = arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                if(max<arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max Elements are : "+max);
        }
        static void Length(int[] arr)
        {
            int Length1 = arr.Length;
            Console.WriteLine("The length of an array is  "+Length1);
        }
        static void jagged()
        {
            Console.WriteLine("JAGGED ARRAYS \n METHOD - 1");
            int[][] arrays = new int[4][];
            arrays[0] = new int[] {1,2,3,4};
            arrays[1] = new int[] {11,24,43};
            arrays[2] = new int[] {89,23};
            arrays[3] = new int[] {3,5,34,221,12,45,42};

            for(int i =0;i<arrays.Length;i++)
            {
                Console.Write("Row({0}) : \t",i);
                for(int j =0;j<arrays[i].Length;j++)
                {
                    Console.Write("{0}\t",arrays[i][j]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
