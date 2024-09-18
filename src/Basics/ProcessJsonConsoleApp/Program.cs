using ProcessJsonConsoleApp.Models;
using Newtonsoft.Json;

Console.WriteLine("Hello, Json!");


string json = File.ReadAllText("Assets/process.json");

Console.WriteLine(json);

TruckUnload truckUnload = JsonConvert.DeserializeObject<TruckUnload>(json);


string output = JsonConvert.SerializeObject(truckUnload);

TruckUnload truckUnload1 = new TruckUnload(json);
TruckUnload truckUnload2 = new TruckUnload();


Header header = new Header();
header.ReportType = ReportTypes.Etanol;

if (header.ReportType == ReportTypes.Etanol)
{
    Console.WriteLine((byte)header.ReportType);
}