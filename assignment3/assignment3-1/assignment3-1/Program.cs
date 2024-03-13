/*
 *编写面向对象程序实现长方形、正方形、三角形等形状的类。
 *每个形状类都能计算面积、判断形状是否合法。
 *请尝试合理使用接口/抽象类、属性来实现。
 */


using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
//抽象类
class Program
{


    abstract class Shape
    {
        public abstract double countArea();  //求面积
        public abstract bool isRational();   //判断形状是否合法


    }

    //圆形
    class Circle : Shape
    {
        public double r { get; set; }

        public Circle(double a)
        {
            this.r = a;
        }
        public override double countArea()
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public override bool isRational()
        {
            return r > 0;
        }

    }


    //长方形
    class Rectangle : Shape
    {

        public double width { get; set; }
        public double length { get; set; }
        public Rectangle(int a, int b)
        {
            this.length = a;
            this.width = b;
        }
        public override double countArea()
        {
            return width * length;
        }

        public override bool isRational()
        {
            return width > 0 && length > 0;
        }

    }

    //正方形
    class Square : Shape
    {
        public double d { get; set; }

        public Square(int a)
        {
            this.d = a;

        }
        public override double countArea()
        {
            return d*d;
        }

        public override bool isRational()
        {
            if (d <= 0)
            {
                throw new ArgumentException("正方形的边长应该是正数");
            }
            return true;
        }

    }

    //三角形
    class Triangle : Shape
    {
        public double bottom { get; set; }  //底
        public double height { get; set; } //高
        public Triangle(int a, int b)
        {
            bottom = a;
            height = b;
        }
        public override double countArea()
        {
            return 0.5 * bottom * height;
        }
        public override bool isRational()
        {

            return bottom > 0 && height > 0;
        }

    }
    //工厂
    class Factory
    {
        public static Shape CreateFunc(int num)
        { 
            switch (num)
            {
                case 1:
                    Console.WriteLine("请输入圆形的半经");
                    string rInput = Console.ReadLine();
                    if (!int.TryParse(rInput, out int r))
                    {
                        Console.WriteLine("输入的不是有效的整数。请重新输入。");
                        return null;
                    }
                    return new Circle(r);
                case 2:
                    
                    Console.WriteLine("请输入长方形的长");
                    string lengthInput = Console.ReadLine();
                    if (!int.TryParse(lengthInput, out int length))
                    {
                        Console.WriteLine("输入的不是有效的整数。请重新输入。");
                        return null;
                    }
                    Console.WriteLine("请输入长方形的宽");
                    string widthInput = Console.ReadLine();
                    if (!int.TryParse(widthInput, out int width))
                    {
                        Console.WriteLine("输入的不是有效的整数。请重新输入。");
                        return null;
                    }
                    return new Rectangle(length,width);

                case 3:
                    Console.WriteLine("请输入正方形的边长");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int d))
                    {
                        Console.WriteLine("输入的不是有效的整数。请重新输入。");
                        return null;
                    }
                    return new Square(d);

                case 4:

                    Console.WriteLine("请输入三角形的底边");
                    string bottomInput = Console.ReadLine();
                    if (!int.TryParse(bottomInput, out int bottom))
                    {
                        Console.WriteLine("输入的不是有效的整数。请重新输入。");
                        return null;
                    }
                    Console.WriteLine("请输入三角形的高 ");
                    string heightInput = Console.ReadLine();
                    if (!int.TryParse(bottomInput, out int height))
                    {
                        Console.WriteLine("输入的不是有效的整数。请重新输入。");
                        return null;
                    }
                    return new Triangle(bottom,height);


                default:
                    Console.WriteLine("输入的数字有误");
                    return null;

            }

        }

    }

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("请选择您要计算的形状的序号：");
            Console.WriteLine("1、圆形 2、长方形 3、正方形 4、三角形 0、退出");
            string input = Console.ReadLine(); // 读取用户输入的字符串
            int index = 0;
            if (int.TryParse(input, out index))
            {
                Console.WriteLine("您输入的数是" + index);
            }
            else
            {
                Console.WriteLine("输入的不是有效的整数。");
            }
            if (index == 0)
            {
                Console.WriteLine("退出程序。");
                break; // 终止循环
            }
            Shape shape = Factory.CreateFunc(index);
            if (shape != null)
            {
                if (shape.isRational())
                {
                    Console.WriteLine("形状合理");
                    Console.WriteLine("面积：" + shape.countArea());
                }
                else
                {
                    Console.WriteLine("形状不合理");
                }
            }
            Console.WriteLine();
        }
    }

}






