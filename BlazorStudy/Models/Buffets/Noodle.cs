using System.ComponentModel.DataAnnotations;

namespace BlazorStudy.Models.Buffets
{
    public class Noodle
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(25)]
        public string? Name { get; set; }

        [Required]
        public int? BrothId { get; set; }
        public Broth? Broth { get; set; }
    }
}
