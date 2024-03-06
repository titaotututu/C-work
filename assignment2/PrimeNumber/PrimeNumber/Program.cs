//编写程序输出用户指定数据的所有素数因子。
using System;
class PrimeNum
{   
    static void Main(string[] args)
    {
        System.Console.WriteLine("请输入待查找的数据：");
        int num=int.Parse(Console.ReadLine());  //读入用户输入的数据
        System.Console.WriteLine("该数的素数因子为：");
        int[] myResult=CountPrimeNumber(num);
        foreach(int i in myResult)
        {   if (i != 0)
                Console.Write(i + " ");
            else break;
        }
    }

   
    public static int[] CountPrimeNumber(int num)  //返回一个数组
    {
        int[] arr=new int[num/2];
        int index = 0;//素数的个数
        for (int i = 2; i <= num;)
        {
            if (num % i == 0)
            {
                arr[index] = i;
                num /= i;
                index++;
            }
            else i++;
        }
        return arr;
    }

   
}