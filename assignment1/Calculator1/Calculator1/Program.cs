/*
 接受两个数字和一个运算符作为输入，并打印出计算结果
 */

using System.Xml.Serialization;

namespace Calculator1
{
    class Program
    {
        private static double num1 = 0,num2 = 0, num3 = 0;
        private static string str = null;  //接收用户输入的字符串，后面将其转成数

        //显示菜单
        static void displayMenu()
        {
            Console.Clear();
            Console.WriteLine("本程序支持的功能如下：");
            Console.WriteLine("         +    加法");
            Console.WriteLine("         -    减法");
            Console.WriteLine("         *    乘法");
            Console.WriteLine("         /    除法");
            Console.WriteLine("         %    取余");
            Console.WriteLine("         0    结束程序");
        }

        //输入
        static void getnum1()
        {
            try
            {
                Console.WriteLine("请输入第一个数：");
                num1 = double.Parse(Console.ReadLine());

            }
            catch(Exception e)    //捕获异常并给出提示
            {
                Console.WriteLine("输入的数有误，请重新输入：");
                getnum1();  //调用自身，重新输入

            }
        }
        static void getnum2()
        {
            try
            {
                Console.WriteLine("请输入第一个数：");
                num2 = double.Parse(Console.ReadLine());

            }
            catch (Exception e)    //捕获异常并给出提示
            {
                Console.WriteLine("输入的数有误，请重新输入：");
                getnum1();  //调用自身，重新输入

            }
        }

       // 计算方法
        static void getnum3(string choice)
        {
            switch (choice)
            {
                case "+":
                    num3 = num1 + num2;
                    break;
                case "-":
                    num3 = num1 - num2;
                    break;
                case "*":
                    num3 = num1*num2;
                    break;
                case "/":
                    try
                    {
                        if (num2 == 0)
                            throw new DivideByZeroException();//除数为0时抛出异常
                        else
                            num3 = num1 / num2;
                    }
                    catch(DivideByZeroException)
                    {
                        Console.WriteLine("除数不能为0");
                        Console.WriteLine("请按回车键继续");
                        Console.WriteLine();
                        count();
                    }
                    break;
                case "%":
                    try
                    {
                        if (num2 == 0)
                            throw new DivideByZeroException();//除数为0时抛出异常
                        else
                            num3 = num1 % num2;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("除数不能为0");
                        Console.WriteLine("请按回车键继续");
                        Console.WriteLine();
                        count();
                    }
                    break;
            }
        }

        //主程序，进行计算
    static void count()
        {
            while (true)
            {
                displayMenu();
                Console.WriteLine("请输入将进行的运算符号： （按0退出）");
                str = Console.ReadLine();
                if (str == "0")
                {
                    Console.WriteLine("Bye bye!");
                    Environment.Exit(0);    //立即终止程序
                }
                try
                {
                    if (str == "+" || str == "-" || str == "*" || str == "/" || str == "%")
                    {
                        //获取两个计算的数
                        getnum1();
                        getnum2();
                        getnum3(str);
                        Console.WriteLine("计算结果为：");
                        Console.WriteLine("{0}{1}{2}={3}", num1, str, num2, num3);

                    }
                    else throw new FormatException();

                }
                catch(FormatException) {
                    Console.WriteLine("输入有误，请重新输入：");
                }

                finally {
                    Console.WriteLine("按回车键继续");
                    Console.ReadLine();
                    count();
                }
            }
        }
    static void Main(string[] args)
        {
            count();
        }
    }

}