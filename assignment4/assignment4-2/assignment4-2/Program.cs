
/*
 使用事件机制，模拟实现一个闹钟功能。
闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。
在闹钟走时时或者响铃时，在控制台显示提示信息。

 */

using System;
using System.Threading;

public class AlarmClock  //闹钟类
{
    //定义闹钟Tick事件；
    public event EventHandler Tick;
    //定义响铃事件Alarm
    public event EventHandler Alarm;
    //触发Tick
    protected virtual void ClockTick(EventArgs e)
    {
        if (Tick != null) { 
        Tick(this, e);}

    }
    //触发Alarm
    protected virtual void ClockAlarm(EventArgs e)
    {
        if(Alarm != null)
        {
            Alarm(this, e);
        }
    }

    //启动闹钟
    public void Start()
    {
        for(int i = 0; i < 10; i++)  //用于模拟时间的流逝,十次循环后，闹钟响
        {
            ClockTick(EventArgs.Empty);
            Thread.Sleep(1000);  //每秒Tick一下
        }
        ClockAlarm(EventArgs.Empty);// 触发响铃事件

    }
}

//主程序
class Program
{
    public static void Main(string[] args)
    {
        AlarmClock clock= new AlarmClock(); //创建一个闹钟对象
        //订阅Tick事件
        clock.Tick += (sender, e) => Console.WriteLine("Ticking.....");  //两个参数表示事件的发送者和事件参数
        //订阅Alarm事件
        clock.Alarm += (sender, e) => Console.WriteLine("Alarm ringing .....");

        Console.WriteLine("starting the alarm clock");
        clock.Start();
        Console.WriteLine("按任意键退出");
        Console.ReadKey();


    }
}