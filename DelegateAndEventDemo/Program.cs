using System;
using System.Text;

namespace DelegateAndEventDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);


            var heater = new Heater("RealFire 001", "China Xian");
            var alarm = new Alarm();

            heater.Boiled += alarm.MakeAlert;//注册方法
            heater.Boiled += (new Alarm()).MakeAlert;//给匿名对象注册方法
            heater.Boiled += new Heater.BoiledEventHandler(alarm.MakeAlert);//也可以这么注册
            heater.Boiled += Display.ShowMsg;//注册静态方法

            heater.BoilWater();
            Console.ReadKey();
        }
    }
}