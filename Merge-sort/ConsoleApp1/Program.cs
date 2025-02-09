﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //function that prints an array
        static void PrintArray(int[] arr)
        {
            int i;
            for (i = 0; i < arr.Length; i++)
                Console.Write(arr[i]+ " ");
            Console.WriteLine();//print \n after array
        }
        static void MergeSort(int [] arr)
        {
            if (arr.Length == 1)
                return;
            int mid = arr.Length / 2;
            // create 2 sub array from the main array 
            int[] leftArr = new int [mid];
            int[] rightArr = new int [arr.Length-mid];
            int i ;
            //insert the values
            for (i=0; i < mid; i++)
                leftArr[i] = arr[i];
            //insert the values
            for (int j=0; i < arr.Length; i++,j++)
                rightArr[j] = arr[i];
            //while LeftArr.Length=1 create sub array
            MergeSort(leftArr);
            //while RightArray.Length=1 create sub array
            MergeSort(rightArr);

            int leftIndex = 0;
            int rightIndex = 0;
            int mergeIndex = 0;

            for(; leftIndex< leftArr.Length && rightIndex< rightArr.Length; mergeIndex++)
            {
                //if the value in the LeftArr is smaller than the value in the RightArr i will copy it
                if (leftArr[leftIndex] < rightArr[rightIndex])
                {
                    arr[mergeIndex] = leftArr[leftIndex];
                    leftIndex++;
                }
                //if the value in the RightArr is smaller than the value in the LeftArr i will copy it
                else
                {
                    arr[mergeIndex] = rightArr[rightIndex];
                    rightIndex++;
                }
            }
            //if the LeftArr still has values i will copy it
            for (; leftIndex <leftArr.Length;leftIndex++,mergeIndex++)
            {
                arr[mergeIndex] = leftArr[leftIndex];
            }
            //if the RightArr still has values i will copy it
            for (; rightIndex < rightArr.Length; rightIndex++, mergeIndex++)
            {
                arr[mergeIndex] = rightArr[rightIndex];
            }
       
        }
        static void Main(string[] args)
        {
            int[] arr = {6, 1, 8, 2, 3, 9,0};
            if(arr.Length==1)
            {
                Console.WriteLine("The array is sorted :");
                PrintArray(arr);
            }  
            else
            { 
            Console.WriteLine("Array befor merge sort :");
            PrintArray(arr);
            MergeSort(arr);
            Console.WriteLine("Array after merge sort :");
            PrintArray(arr);
            }
        }
    }
}
