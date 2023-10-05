using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalTask_Backend.Entities

{

    public class ProgramDetails
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProgramId { get; set; } // Define a primary key

        [Required] // ProgramTitle is required
        public string ProgramTitle { get; set; }

        [AllowNull]
        public string SummaryOfProgram { get; set; }

        [Required] // ProgramDescription is required
        public string ProgramDescription { get; set; }

        public string KeySkills { get; set; }
        public string ProgramBenefits { get; set; }
        public string ApplicationCriteria { get; set; }

        [Required] // ProgramType is required
        public string ProgramType { get; set; }

        public DateTime? ProgramStart { get; set; }

        [Required] // ApplicationOpen is required
        public DateTime ApplicationOpen { get; set; }

        [Required] // ApplicationClose is required
        public DateTime ApplicationClose { get; set; }

        public string? Duration { get; set; }

        [Required] // ProgramLocation is required
        public string ProgramLocation { get; set; }

        public string MinQualifications { get; set; }
        public int? MaxNumberOfApplications { get; set; }

        public ICollection<User> ApplicationForms { get; set; }
        public ICollection<WorkFlow> Workflows { get; set; }
    }
}
