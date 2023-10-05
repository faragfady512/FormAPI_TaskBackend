using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalTask_Backend.Entities
{
    public class WorkFlow
    {
    
            public int WorkflowID { get; set; }
            public int ProgramID { get; set; }

            [Required] // StageName is required
            public string StageName { get; set; }

            public bool VideoInterview { get; set; }
            public string InterviewQuestions { get; set; }
            public string AdditionalInformation { get; set; }
            public string MaxDuration { get; set; }
            public DateTime? DeadlineForVideo { get; set; }

            public ProgramDetails Program { get; set; }
        }
    }

