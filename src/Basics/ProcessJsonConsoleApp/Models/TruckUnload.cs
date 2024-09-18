using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessJsonConsoleApp.Models
{
    class TruckUnload
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

        public void DoWork()
        {

        }
    }

    class ProcessReport
    {
        public string ProcessType { get; set; } // Wlasciwosc (Property)
        public Header Header { get; set; }

        public ProcessReport()
        {
            Header = new Header();
            ProcessType = "TU1";
        }
    }

    class Header
    {
        public string ControllerDpName { get; set; }
        public ReportTypes ReportType { get; set; }
    }

    enum ReportTypes : byte
    {
        Etanol = 1,
        Ester = 2,
        Addin = 3,
    }
}
