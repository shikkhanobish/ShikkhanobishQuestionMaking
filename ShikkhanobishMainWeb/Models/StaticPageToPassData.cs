using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShikkhanobishMainWeb.Models
{
    public static class StaticPageToPassData
    {
        public static string thisOperatorID { get; set; }
        public static string Name { get; set; }
        public static List<Chapter> allc { get; set; }
        public static List<Subject> allsub { get; set; }
        public static List<ClassInfo> allClass { get; set; }
        public static IBrowserFile selectedFilesqs { get; set; }
        public static IBrowserFile selectedFilesop1 { get; set; }
        public static IBrowserFile selectedFilesop2 { get; set; }
        public static IBrowserFile selectedFilesop3 { get; set; }
        public static IBrowserFile selectedFilesop4 { get; set; }
        public static string qsPrv = "";
        public static string op1Prv = "";
        public static string op2Prv = "";
        public static string op3Prv = "";
        public static string op4Prv = "";
        public static int index { get; set; }
    }
}
