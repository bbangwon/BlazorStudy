using System.ComponentModel.DataAnnotations;

namespace BlazorStudy.Models.Candidates
{
    /// <summary>
    /// 후보자, 지원자(Applicant)
    /// </summary>
    public class Candidate
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }
        public bool IsEnrollment { get; set; }
    }
}
