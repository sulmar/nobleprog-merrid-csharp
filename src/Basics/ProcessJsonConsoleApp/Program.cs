using ProcessJsonConsoleApp.Models;

Console.WriteLine("Hello, Json!");


string json = File.ReadAllText("Assets/process.json");

Console.WriteLine(json);

TruckUnload truckUnload1 = new TruckUnload();
truckUnload1.Process = new ProcessReport();
truckUnload1.Process.Header = new Header();
truckUnload1.Process.ProcessType = "TU1";

TruckUnload truckUnload2 = new TruckUnload();



Header header = new Header();
header.ReportType = ReportTypes.Etanol;

if (header.ReportType == ReportTypes.Etanol)
{
    Console.WriteLine((byte) header.ReportType);
}