using ProcessJsonConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessJsonConsoleApp.Infrastructures
{

    internal class FakeDeviceRepository : IDeviceRepository
    {
        public Device GetDeviceById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Device> GetDevices()
        {
            List<Device> devices = new List<Device>();
            devices.Add(new Pump("BasePump1", new Inverter()));
            devices.Add(new Pump("BasePump2", new SoftStart()));
            devices.Add(new Valve("BasePump1"));
            return devices;
        }
    }
}
