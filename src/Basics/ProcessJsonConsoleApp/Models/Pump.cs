using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessJsonConsoleApp.Models
{
    public abstract class Device
    {
        public string Name { get; set; }

        private string _label;
        public string Label
        {
            get
            {
                return _label;
            }

            set
            {
                if (value.Length > 3)
                    _label = value;
                else
                    throw new ArgumentException();
            }
        }
    }


    //public abstract class PowerSupply
    //{
    //    public double Voltage { get; set; }
    //}

    public class Inverter
    {
        public double Voltage { get; set; }
    }

    //public class SoftStart 
    //{
    //    public double Voltage { get; set; }
    //}

    public class Pump : Device // Dziedziczenie
    {
        public bool IsRunning { get; private set; }
        public Inverter Inverter { get; set; }

        public void Start()
        {
            if (Inverter.Voltage > 0 && !IsRunning)
            {
                IsRunning = true;
            }
        }
    }

    public class Valve : Device
    {
        public bool IsOpened { get; set; }
        public int Mode { get; set; }
    }
}
