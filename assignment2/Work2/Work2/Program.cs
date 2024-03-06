using System;
using System.Collections.Specialized;

//求整数数组的最大值、最小值、平均值和所有数组元素的和。

class Program2
{
    static void Main(string[] args)
    {
        int[] arr = { 22, 33, 55, 77, 90 };  //新建数组
        int max = arr[0];
        int min = arr[0];
        int average = 0;
        int sum=0;
        for(int i=0;i<arr.Length;i++) {
            sum += arr[i];
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        average =sum/arr.Length;

        Console.WriteLine("Max of array:" + max);
        Console.WriteLine("Min of array:" + min);
        Console.WriteLine("Average of array:" + average);
        Console.WriteLine("Sum of array:" + sum);

    }

}