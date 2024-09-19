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


    public abstract class PowerSupply
    {
        public double Voltage { get; set; } = 12.01f;

        public bool IsReady()
        {
            return this.Voltage > 0;
        }
    }

    public class Inverter : PowerSupply
    {
    }

    public class SoftStart : PowerSupply
    {
        public bool Bit1 { get; set; }
        public bool Bit2 { get; set; }
    }

    public class Solar : PowerSupply
    {

    }

    public class Pump : Device // Dziedziczenie
    {
        public bool IsRunning { get; private set; }
       
        private PowerSupply powerSupply;  // Kompozycja

        public Pump(PowerSupply powerSupply)
        {
            this.powerSupply = powerSupply;
        }

        public void Start()
        {
            if (powerSupply.IsReady() && !IsRunning)
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
