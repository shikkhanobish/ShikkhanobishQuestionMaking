using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShikkhanobishMainWeb.Models
{
    public class OperatorEntryCount
    {
        public int operatorID { get; set; }
        public int UploadCount { get; set; }
        public int ApprovedCount { get; set; }
        public int DeclineCount { get; set; }
        public int PendingCount { get; set; }
        public int Type { get; set; }
        public string Response { get; set; }
    }
}
