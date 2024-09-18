using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessJsonConsoleApp.Models
{
    public class TruckUnload
    {
        public string Filename { get; set; }
        public ProcessReport Process { get; set; }

        public TruckUnload() // Konstructor
        {
            Process = new ProcessReport();
        }

        public TruckUnload(string filename)
            : this()
        {
            this.Filename = filename;
        }

        public TruckUnload(int number)
            : this("sample.json") 
        {

        }

         void DoWork()
        {

        }


        public static int PreTime { get; set; }

        public static int CalculateProcessTime(int volume)
        {
            return PreTime + volume * 1;
        }
    }

    public class ProcessReport
    {
        public string ProcessType { get; set; } // Wlasciwosc (Property)
        public Header Header { get; set; }

        public ProcessReport()
        {
            Header = new Header();
            ProcessType = "TU1";
        }
    }

    public class Header
    {

        // Atrybut
        [JsonProperty("ControllerDpName")]
        public string ControllerDataPointName { get; set; }

        public ReportTypes ReportType { get; set; }
    }

    public enum ReportTypes : byte
    {
        Etanol = 1,
        Ester = 2,
        Addin = 3,
    }
}
