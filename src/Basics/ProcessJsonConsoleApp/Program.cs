using ProcessJsonConsoleApp.Models;
using Newtonsoft.Json;
using ProcessJsonConsoleApp.Infrastructures;

Console.WriteLine("Hello, Json!");

IRequestRailService requestService = new InlineRequestService();
requestService.SendRailLoadRequest("A");


IDeviceRepository repository = new JsonDeviceRepository();
// repository.Add(new Pump(new Inverter()));

List<Device> devices = repository.GetDevices();

foreach (Device device in devices)
{
    Console.WriteLine(device.Label);

    if (device is Pump pump)
    {
        pump.Start();

        pump.Show();

        Console.WriteLine(pump.IsRunning);
    }



}



TruckUnload.PreTime = 5;
int processTime = TruckUnload.CalculateProcessTime(100);


string json = File.ReadAllText("Assets/process.json");

Console.WriteLine(json);

// Deserializacja
TruckUnload truckUnload = JsonConvert.DeserializeObject<TruckUnload>(json);


// Serializacja
string output = JsonConvert.SerializeObject(truckUnload);
Console.WriteLine(output);

TruckUnload truckUnload1 = new TruckUnload(json);
TruckUnload truckUnload2 = new TruckUnload();


Header header = new Header();
header.ReportType = ReportTypes.Etanol;

if (header.ReportType == ReportTypes.Etanol)
{
    Console.WriteLine((byte)header.ReportType);
}



static List<Device> GetJsonDevices()
{
    throw new NotImplementedException();


}