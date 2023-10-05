using System.ComponentModel.DataAnnotations;
using System;

namespace CapitalTask_Backend.Dto
{
    public class WorkFlowDto
    {
       
        public string StageName { get; set; }

        public bool VideoInterview { get; set; }
        public string InterviewQuestions { get; set; }
        public string AdditionalInformation { get; set; }
        public string MaxDuration { get; set; }
        public DateTime? DeadlineForVideo { get; set; }
    }
}
