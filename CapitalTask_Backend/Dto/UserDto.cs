using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace CapitalTask_Backend.Dto
{
    public class UserDto
    {
       
        public string ProfileImage { get; set; }

       
        public string FirstName { get; set; }

   
        public string LastName { get; set; }


        public string Email { get; set; }

        public string? Phone { get; set; }
        public string? Nationality { get; set; }
        public string? CurrentResidence { get; set; }
        public string? IDNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
    }
}
