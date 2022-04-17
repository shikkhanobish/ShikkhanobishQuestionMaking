using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShikkhanobishMainWeb.Models
{
    public class teacherSubmitHistory
    {
        public string teacherSubmitHistoryID { get; set; }
        public string questionID { get; set; }
        public string date { get; set; }
        public string operatorID { get; set; }
        public string Response { get; set; }
    }
}
