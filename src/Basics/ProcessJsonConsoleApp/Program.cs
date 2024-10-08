﻿using ProcessJsonConsoleApp.Models;
using Newtonsoft.Json;
using ProcessJsonConsoleApp.Infrastructures;

Console.WriteLine("Hello, Json!");

IRequestRailService requestService = new InlineRequestService();
requestService.SendRailLoadRequest("A");


IDeviceRepository repository = new FakeDeviceRepository();
// repository.Add(new Pump(new Inverter()));

List<Device> allDevices = repository.GetDevices();

// SQL: SELECT TOP(10) * FROM dbo.Devices WHERE Area='BasePump1 ORDER BY Name'

// Linq
List<Device> filteredDevices = allDevices
    .Where(device => device.Area == "BasePump1")
    .OrderBy(device => device.Name)
    .Take(10)
    .ToList();

//foreach(Device device in allDevices)
//{
//    if (device.Area == "BasePump1")
//    {
//        filteredDevices.Add(device);
//    }
//}    


foreach (Device device in filteredDevices)
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