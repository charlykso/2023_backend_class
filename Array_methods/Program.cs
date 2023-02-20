// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Array_methods.Arrays newArr = new Array_methods.Arrays();

int[] list = {20, 10, 5, 14, 2};
// Console.WriteLine(Array_methods.Arrays.array_sum(list));
Console.WriteLine(newArr.array_max(list));


// newArr.print_multi_array();

string country = "Nigeria";
newArr.MyMethod(country);

string str = "hello";
Console.WriteLine(newArr.reverse_string(str));
