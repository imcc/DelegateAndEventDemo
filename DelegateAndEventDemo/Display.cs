using System;

namespace DelegateAndEventDemo
{
    /// <summary>
    /// 显示器
    /// </summary>
    public class Display
    {
        public static void ShowMsg(object sender, Heater.BoiledEventArgs e)
        {
            var heater = (Heater)sender;
            Console.WriteLine("Display：{0} - {1}: ", heater.Area, heater.Type);
            Console.WriteLine("Display：水快烧开了，当前温度：{0}度。", e.Temperature);
            Console.WriteLine();
        }
    }
}