using System;

namespace CapitalTask_Backend.Dto
{
    public class EducationDto
    {
        public string School { get; set; }
        public string Degree { get; set; }
        public string CourseName { get; set; }
        public string LocationOfStudy { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
