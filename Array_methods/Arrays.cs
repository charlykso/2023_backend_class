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
            // print_multi_array();
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

        public void print_multi_array()
        {
            int[,] numbers = {
                { 1, 4, 2 }, 
                { 3, 6, 8 } 
                };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }
        }

        public void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
            // return country;
        }

        public string reverse_string(string str)
        {
            string result = "";
            int count = str.Length - 1;

            for (int i = 0; i <= count; )
            {
                result = result + str[count];
                count--;
            }
            return result;
        }
    }
}
