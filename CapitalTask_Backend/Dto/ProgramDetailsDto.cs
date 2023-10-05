using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapitalTask_Backend.Dto
{
    public class ProgramDetailsDto
    {
   
        //public int ProgramId { get; set; } 

   
        public string ProgramTitle { get; set; }

   
        public string SummaryOfProgram { get; set; }

   
        public string ProgramDescription { get; set; }

        public string KeySkills { get; set; }
        public string ProgramBenefits { get; set; }
        public string ApplicationCriteria { get; set; }

   
        public string ProgramType { get; set; }

        public DateTime? ProgramStart { get; set; }

     
        public DateTime ApplicationOpen { get; set; }

      
        public DateTime ApplicationClose { get; set; }

        public string? Duration { get; set; }


        public string ProgramLocation { get; set; }

        public string MinQualifications { get; set; }
        public int? MaxNumberOfApplications { get; set; }
    }
}
