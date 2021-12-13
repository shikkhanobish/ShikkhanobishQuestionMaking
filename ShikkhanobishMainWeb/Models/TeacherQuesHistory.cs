using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShikkhanobishMainWeb.Models
{
    public class TeacherQuesHistory
    {
        
        public int tqID { get; set; }
        public int teacherID { get; set; }
        public int questionID { get; set; }
        public string review { get; set; }
    
    }
}
