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

    public class Pump : Device
    {
        
        public bool IsRunning { get; set; }
    }

    public class Valve : Device
    {
        public bool IsOpened { get; set; }
        public int Mode { get; set; }
    }
}
