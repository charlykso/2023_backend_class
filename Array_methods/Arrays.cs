using System;

namespace Array_methods
{
    public class Arrays
    {
        public static int array_sum(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public int array_max(int[] arr)
        {
            int max = 0;
            int x = 0;
            foreach (var i in arr)
            {
                for (int j = x + 1; j < arr.Length; j++)
                {
                    if (i > arr[j])
                    {
                        if (max < arr[j])
                        {  
                            max = i;
                        }
                    }else if(max > arr[j])
                    {
                        continue;
                    }
                    else{
                        max = arr[j];
                    }
                }
                x++;
            }
            return max;
        }
    }
}