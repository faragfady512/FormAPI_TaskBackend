using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalTask_Backend.Entities
{
    public class WorkExperience
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExperienceID { get; set; }
        public int UserID { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string LocationOfWork { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public User User { get; set; }
    }
}
