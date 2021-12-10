using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class array
    {
        public void Indexmin()
        {
            int[] arr = { 6, 7, 9 };
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }


            }
            int Index = Array.IndexOf(arr, min);
            Console.WriteLine(min);
            Console.WriteLine(Index);
        }
    }
}
