/*
 * 为示例中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。
 * 通过调用这个方法打印链表元素，
 * 求最大值、最小值和求和（使用lambda表达式实现）
 *
 */

using System;
using System.Diagnostics;
//定义链表节点
public class Node<T>
{
    public Node<T> next{get;set;}  //next指针
    public T data { get; set; }

    public Node(T t)
    {
        next = null;
        data = t;
    }
}

//定义泛型链表类
public class GenericList<T>
{
    private Node<T> tail;  //定义尾结点
    private Node<T> head;  //定义头结点
    public GenericList()  //初始化
    {
        tail = null;
        head = null;
    }
    public Node<T> Head  //获取头节点的方法
    {
        get => head;
    }

    public void Add(T t)
    {
        Node<T> n = new Node<T>(t);
        if (tail == null)
        {
            head = tail = n;
        }
        else
        {
            tail.next = n;
            tail= n;    
        }
    }
    //ForEach方法
    public void ForEach(Action<T> action)
    {
        Node<T> current= head;
        while (current!=null)
        {
            action(current.data);
            current= current.next;  
        }

    }
}

//主程序
class Program
{
    public static void Main(string[] args)
    {
        //创建一个int类型的链表对象
        GenericList<int>LinkList= new GenericList<int>();
        LinkList.Add(99);
        LinkList.Add(2);
        LinkList.Add(2);
        LinkList.Add(8);
        LinkList.Add(7);
        LinkList.Add(9);
        LinkList.Add(30);
        Console.WriteLine("链表中的元素为：");
        LinkList.ForEach(data=>Console.WriteLine(data));  //打印链表保存的数据
        int max =LinkList.Head.data;
        int min =LinkList.Head.data;
        int sum = 0;
        LinkList.ForEach(data =>
        {
            if (data > max)
            {
                max = data;
            }
            if (data < min)
            {
                min = data;
            }
            sum += data;
        });

        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Sum: " + sum);

    }
}

