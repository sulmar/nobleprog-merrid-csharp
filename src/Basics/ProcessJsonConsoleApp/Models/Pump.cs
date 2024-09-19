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

        public Pump(PowerSupply powerSupply)
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
