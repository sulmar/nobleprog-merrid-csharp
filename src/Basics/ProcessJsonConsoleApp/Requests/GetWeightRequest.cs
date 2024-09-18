using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessJsonConsoleApp.Requests
{
    public class GetWeightRequest
    {
        public string DataPointName { get; set; } = "DP01";
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(5);
    }
}
