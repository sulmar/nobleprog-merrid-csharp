﻿using ProcessJsonConsoleApp.Models;
using Newtonsoft.Json;

Console.WriteLine("Hello, Json!");

List<Device> devices = GetFakeDevices();

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

static List<Device> GetFakeDevices()
{
    List<Device> devices = new List<Device>();
    devices.Add(new Pump(new Inverter()));
    devices.Add(new Pump(new SoftStart()));
    devices.Add(new Valve());
    return devices;
}