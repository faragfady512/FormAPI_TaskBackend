using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalTask_Backend.Entities
{
    public class Education
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EducationID { get; set; }

        
        
        public string School { get; set; }
        public string Degree { get; set; }
        public string CourseName { get; set; }
        public string LocationOfStudy { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }


        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
