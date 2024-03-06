using System;
using System.Runtime.InteropServices;
//判断一个矩阵是不是托普利兹矩阵
class Program4
{
    static void Main(string[] args)
    {
        int[][] matrix = new int[3][];
        matrix[0] = new int[]{ 1, 2, 3, 4 };
        matrix[1] = new int[]{ 5, 1, 2, 3 };
        matrix[2] = new int[]{ 9, 5, 1, 2 };
    
        bool flag =IsToplitzMatrix(matrix);
        string result = flag ? "True" : "False";
        Console.WriteLine(result);
    }
    static bool IsToplitzMatrix(int[][] matrix)
    {
        for(int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j<matrix[i].Length; j++)
            {
                if (i != 0 && j != 0 && matrix[i][j] != matrix[i - 1][j - 1])
                {
                    return false;
                }

            }
        }
        return true;

    }
}
