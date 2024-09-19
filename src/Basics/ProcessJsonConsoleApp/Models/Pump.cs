using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessJsonConsoleApp.Models
{

    public class Pump : Device // Dziedziczenie
    {
        public bool IsRunning { get; private set; }

        private PowerSupply powerSupply;  // Kompozycja

        public Pump(string area, PowerSupply powerSupply)
             : base(area)
        {
            this.powerSupply = powerSupply;
        }

        public void Show()
        {
            powerSupply.Show();
        }

        public void Start()
        {
            if (powerSupply.IsReady() && !IsRunning)
            {
                IsRunning = true;
            }
        }
    }
}
