using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalTask_Backend.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        
        public string ProfileImage { get; set; }

        [Required] // FirstName is required
        public string FirstName { get; set; }

        [Required] // LastName is required
        public string LastName { get; set; }

        [Required] // Email is required and must be in email format
        [EmailAddress]
        public string Email { get; set; }

        public string? Phone { get; set; }
        public string? Nationality { get; set; }
        public string? CurrentResidence { get; set; }
        public string? IDNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }

        public ICollection<Question> Questions { get; set; }

        public ProgramDetails ProgramDetails { get; set; }
    }
}
