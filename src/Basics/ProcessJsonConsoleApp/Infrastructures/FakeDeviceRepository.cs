using ProcessJsonConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessJsonConsoleApp.Infrastructures
{


    interface IDeviceRepository
    {
        List<Device> GetDevices();
        Device GetDeviceById(int id);
    }
        
    internal class FakeDeviceRepository : IDeviceRepository
    {
        public Device GetDeviceById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Device> GetDevices()
        {
            List<Device> devices = new List<Device>();
            devices.Add(new Pump(new Inverter()));
            devices.Add(new Pump(new SoftStart()));
            devices.Add(new Valve());
            return devices;
        }
    }
    internal class JsonDeviceRepository : IDeviceRepository
    {
        public void Add(Device device)
        {
            throw new NotImplementedException();
        }

        public Device GetDeviceById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Device> GetDevices()
        {
            throw new NotImplementedException();
        }
    }
}
