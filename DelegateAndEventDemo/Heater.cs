using System;

namespace DelegateAndEventDemo
{
    public class Heater
    {
        private int _temperature;
        public string Type { get; set; }
        public string Area { get; set; }

        public Heater() { }

        public Heater(string type, string area)
        {
            Type = type;
            Area = area;
        }

        public delegate void BoiledEventHandler(object sender, BoiledEventArgs e);

        public event BoiledEventHandler Boiled;

        public class BoiledEventArgs : EventArgs
        {
            public readonly int Temperature;
            public BoiledEventArgs(int temperature)
            {
                this.Temperature = temperature;
            }
        }

        //可以供继承自 Heater 的类重写，以便继承类拒绝其他对象对它的监视
        protected virtual void OnBoiled(BoiledEventArgs e)
        {
            //如果有对象注册,调用所有注册对象的方法
            Boiled?.Invoke(this, e);
        }

        //烧水
        public void BoilWater()
        {
            for (var i = 0; i <= 100; i++)
            {
                _temperature = i;
                if (_temperature > 95)
                {
                    var e = new BoiledEventArgs(_temperature);
                    OnBoiled(e);
                }
            }
        }
    }
}
