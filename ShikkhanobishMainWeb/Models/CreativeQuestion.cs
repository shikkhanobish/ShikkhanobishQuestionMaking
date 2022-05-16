using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShikkhanobishMainWeb.Models
{
    public class CreativeQuestion
    {
        public string cQuestionID { get; set; }
        public int classID { get; set; }
        public int subjectID { get; set; }
        public int chapterID { get; set; }
        public int topicID { get; set; }
        public string className { get; set; }
        public string subjectName { get; set; }
        public string ChapterName { get; set; }
        public string mainQuestion { get; set; }
        public string firstQuestion { get; set; }
        public string secondQuestion { get; set; }
        public string thirdQuestion { get; set; }
        public string forthQuestion { get; set; }
        public string firstqsImg { get; set; }
        public string secodqsImg { get; set; }
        public string thirdqsImg { get; set; }
        public string forthqsImg { get; set; }
        public string firstqsImgdis { get; set; }
        public string secodqsImgdis { get; set; }
        public string thirdqsImgdis { get; set; }
        public string forthqsImgdis { get; set; }
        public string firstqsAns { get; set; }
        public string secondqsAns { get; set; }
        public string thirqsAns { get; set; }
        public string forthqsAns { get; set; }
        public string firstqsAnsImg { get; set; }
        public string secondqsAnsImg { get; set; }
        public string thirqsAnsImg { get; set; }
        public string forthqsAnsImg { get; set; }
        public string firstqsAnsImgdis { get; set; }
        public string secondqsAnsImgdis { get; set; }
        public string thirqsAnsImgdis { get; set; }
        public string forthqsAnsImgdis { get; set; }
        public int review { get; set; }
        public string Response { get; set; }
    }
}
