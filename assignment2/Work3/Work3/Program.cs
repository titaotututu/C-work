using System;
/*
 用“埃氏筛法”求2~ 100以内的素数。2~ 100以内的数，先去掉2的倍数，
再去掉3的倍数，再去掉4的倍数，以此类推...最后剩下的就是素数。
 */

//要将不大于根号n的所有素数的倍数剔除，剩下的就是素数 
 class Program3
{
    static void Main(string[] args)
    {
        int max = 100;
        bool[] isPrime = new bool[max + 1];  //记录该数是否为素数，最后输出相应的编号
        for(int i = 2; i <= max; i++)  //将所有的数都标记为素数
        {
            isPrime[i] = true;
        }
        GetResult(isPrime,max);
    }

    static void GetResult(bool[] isPrime,int max)
    {   
        for(int i = 2; i <= Math.Sqrt(max); i++)  //将2、3、4...的倍数去掉
        {
            if (isPrime[i])
            {
                for(int j = i * i; j <= max; j+=i)
                {
                    isPrime[j] = false;                }
            }

        }
        Console.Write("2~100以内的素数：");
        for(int i = 2; i <= max; i++)
        {
            if (isPrime[i])
            {
                Console.Write(i+ " ");
            }
        }
    }
}