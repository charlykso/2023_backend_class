using System;

namespace numberExcercise
{
    public class Newclass
    {
        public static void printName()
        {
            Console.WriteLine("Ikenna");
        }
        public static void numberCCode( string phoneNumber, string countryCode)
        {

            // string numWithCode = "+234";
            int len = phoneNumber!.Length;
            if (phoneNumber![0] == '0')
            {
                for (int i = 1; i < len; i++)
                {

                    countryCode = countryCode + (phoneNumber[i].ToString());
                    // Console.WriteLine(numWithCode);
                }
                
            }else
            {
                Console.WriteLine(phoneNumber); 
            }
                Console.WriteLine(countryCode);

        }


        public static void printIntArr(int[] arr)
        {
            // foreach (var item in arr)
            // {
            //     Console.WriteLine(item);
            // }
            Console.WriteLine(String.Join(",", arr));
        }
        public static int[] RmvElement(int[] arr, int item)
        {
            arr = arr.Where(e => e != item).ToArray();
            return arr;
        }
        


        public static void my_sort_func()
        {
            int[] list = {5, 3, 2, 7, 9, 10};
            int[] newlist = new int[list.Length];
            int counter = list.Length - 1;
            int count = 0;
            Console.WriteLine("Before sorting");
            printIntArr(list);

            for (int i = 0; i < list.Length - i; count++)
            {
                int biggest = 0;
                if (list.Length == 1)
                {
                    newlist[counter] = list[0];
                }
                else
                {
                    for (int j = i + 1; j < list.Length - i; j++)
                    {
                        if (list[i] > list[j] || biggest > list[j])
                        {
                            if (biggest <= list[i])
                            {
                                biggest = list[i];
                            }
                        }
                        else
                        {
                            biggest = list[j];
                        }
                    }
                    newlist[counter] = biggest;
                    list = RmvElement(list, biggest);
                }
                counter--;
                if (counter < 0)
                {
                    break;
                }
            }
            Console.WriteLine("__________________________________");
            Console.WriteLine("After sorting");
            printIntArr(newlist);
        }

        
    }
}
