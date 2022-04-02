using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShikkhanobishMainWeb.Models
{
    public class Question
    {
        public int questionID { get; set; }
        public int classID { get; set; }
        public int index { get; set; }

        public string className { get; set; }
        public int subjectID { get; set; }
        public string publishingDate { get; set; }
        public int chapterID { get; set; }
        public int topicID { get; set; }
        public string mainQuestion { get; set; }
        public string option1 { get; set; }
        public string op1BackColor { get; set; }
        public string op2BackColor { get; set; }
        public string op3BackColor { get; set; }
        public string op4BackColor { get; set; }
        public string opOneImg { get; set; }
        public string opTwoImg { get; set; }
        public string opThreeImg { get; set; }
        public string opFourImg { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
        public string option4 { get; set; }
        public int rightAnswer { get; set; }
        public string qsimgvisi { get; set; }
        public string op1imgvisi { get; set; }
        public string op2imgvisi { get; set; }
        public string op3imgvisi { get; set; }
        public string op4imgvisi { get; set; }
        public int review { get; set; }
        public string reviewName { get; set; }
        public string reviewColor { get; set; }
        public string quesImages { get; set; }
        public string Response { get; set; }
    }
}
