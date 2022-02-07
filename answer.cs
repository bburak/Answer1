// See https://aka.ms/new-console-template for more information

int[] arr = new int[2];

Console.Write("Please give a number as 1st variable:");
arr[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("Please give a number as 2nd variable:");
arr[1] = Convert.ToInt32(Console.ReadLine());


Array.Reverse(arr);
Console.WriteLine("The value of the 1st variable:" + arr[0]);
Console.WriteLine("The value of the 1st variable:" + arr[1]);
