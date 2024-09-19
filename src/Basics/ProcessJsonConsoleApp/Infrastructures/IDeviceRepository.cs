using ProcessJsonConsoleApp.Models;

namespace ProcessJsonConsoleApp.Infrastructures
{
    interface IDeviceRepository
    {
        List<Device> GetDevices();
        Device GetDeviceById(int id);
    }
}
