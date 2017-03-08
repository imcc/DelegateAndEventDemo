using System;

namespace DelegateAndEventDemo
{
    /// <summary>
    /// 警报器
    /// </summary>
    public class Alarm
    {
        public void MakeAlert(object sender, Heater.BoiledEventArgs e)
        {
            var heater = (Heater) sender;
            Console.WriteLine("Alarm：{0} - {1}: ", heater.Area, heater.Type);
            Console.WriteLine("Alarm: 嘀嘀嘀，水已经 {0} 度了：", e.Temperature);
            Console.WriteLine();
        }
    }
}