using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessJsonConsoleApp.Models
{
    class TruckUnload
    {
        public ProcessReport Process { get; set; }

        public TruckUnload()
        {
            Process = new ProcessReport();
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
